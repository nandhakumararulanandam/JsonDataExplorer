using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDataExplorer
{
    public partial class MainForm : Form
    {
        private string InputFilePath { get; set; }
        private string Query { get; set; }
        private DataFileType DataFileExtension { get; set; }
        private JToken[] SearchTokens { get; set; }

        private int CurrentIndex { get; set; }

        private enum DataFileType
        {
            XML,
            JSON,
            UNKNOWN
        }
        public MainForm()
        {
            InitializeComponent();
            buttonNextItem.Enabled = false;
            buttonPreviousItem.Enabled = false;
            labelResultSummary.Text = string.Empty;
        }

        private void ButtonOpenFileDialog_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                InputFilePath = openFileDialog.FileName;
                textBoxInputFilePath.Text = InputFilePath;
                SearchTokens = new JToken[0];
                CurrentIndex = 0;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (!IsValidate(out var message))
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SearchTokens = new JToken[0];
            CurrentIndex = 0;
            ValidateButtons();

            try
            {
                var fileContent = File.ReadAllText(InputFilePath);
                var jObject = JObject.Parse(fileContent);
                var jTokens = jObject.SelectTokens(Query);

                SearchTokens = jTokens as JToken[] ?? jTokens.ToArray();
                if (SearchTokens.Any())
                {
                    textBoxQueryResults.Text = SearchTokens[CurrentIndex].ToString();
                    labelResultSummary.Text = $"Displaying {CurrentIndex + 1}/{SearchTokens.Count()}";
                }
                else
                {
                    textBoxQueryResults.Text = string.Empty;
                    labelResultSummary.Text = string.Empty;
                    MessageBox.Show("No results found, modify the query", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBoxQuery.Focus();
                }
                ValidateButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in processing Query, Please check Query Format : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetFileExtension()
        {
            return Path.GetExtension(InputFilePath).ToUpper().Substring(1);
        }

       
        private bool IsValidate(out string message)
        {
            message = string.Empty;
            if (string.IsNullOrWhiteSpace(InputFilePath))
            {
                message = "Input file can't be empty";
                return false;
            }

            if (!File.Exists(InputFilePath))
            {
                message = "Cannot find input file";
                return false;
            }


            DataFileExtension = DataFileType.UNKNOWN;

            if (Enum.TryParse(GetFileExtension(), out DataFileType extension))
                DataFileExtension = extension;


            if (DataFileExtension == DataFileType.UNKNOWN)
            {
                message = "Invalid input file format";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxQuery.Text))
            {
                message = "Query cannot be empty";
                return false;
            }

            return true;
        }


        private void textBoxInputFilePath_TextChanged(object sender, EventArgs e)
        {
            InputFilePath = textBoxInputFilePath.Text;
        }

        private void buttonNextItem_Click(object sender, EventArgs e)
        {
            CurrentIndex++;
            if (CurrentIndex < SearchTokens.Length)
            {
                textBoxQueryResults.Text = SearchTokens[CurrentIndex].ToString();
                labelResultSummary.Text = $"Displaying {CurrentIndex + 1}/{SearchTokens.Count()}";
            }

            ValidateButtons();
        }


        private void buttonPreviousItem_Click(object sender, EventArgs e)
        {
            CurrentIndex--;
            if (CurrentIndex >= 0)
            {
                textBoxQueryResults.Text = SearchTokens[CurrentIndex].ToString();
                labelResultSummary.Text = $"Displaying {CurrentIndex + 1}/{SearchTokens.Count()}";
            }

            ValidateButtons();
        }
        private void ValidateButtons()
        {
            textBoxQueryResults.Select(0, 0);
            textBoxQueryResults.ScrollToCaret();
            buttonPreviousItem.Enabled = CurrentIndex > 0;
            buttonNextItem.Enabled = CurrentIndex < SearchTokens.Length - 1;
        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {
            Query = textBoxQuery.Text;
        }
    }
}
