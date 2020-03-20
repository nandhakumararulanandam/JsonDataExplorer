using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JsonDataExplorer.Properties;
using Markdig;
using Markdig.SyntaxHighlighting;
using Newtonsoft.Json.Linq;

namespace JsonDataExplorer
{
    public partial class MainForm : Form
    {
        #region Props & Enums

        private string InputFilePath { get; set; }
        private string Query { get; set; }
        private DataFileType DataFileExtension { get; set; }
        private JToken[] SearchTokens { get; set; }
        private int CurrentIndex { get; set; }

        private readonly MarkdownPipeline _syntaxPipeLine;

        private enum Filtering
        {
            Pagination = 0,
            List = 1,
            UniqueList = 2,
            UniqueListWithCount = 3,
        }

        private enum DataFileType
        {
            // ReSharper disable InconsistentNaming
            // ReSharper disable UnusedMember.Local
            XML,
            JSON,
            UNKNOWN
            // ReSharper enable UnusedMember.Local
            // ReSharper enable InconsistentNaming
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            buttonNextItem.Enabled = false;
            buttonPreviousItem.Enabled = false;
            labelResultSummary.Text = string.Empty;
            _syntaxPipeLine = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseSyntaxHighlighting()
                .Build();
            comboBoxDisplayFormat.SelectedIndex = 0;
            comboBoxFiltering.SelectedIndex = 0;
            webBrowserResults.Hide();
        }

        #region Button Events

        private void ButtonOpenFileDialog_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK) return;
            InputFilePath = openFileDialog.FileName;
            textBoxInputFilePath.Text = InputFilePath;
            SearchTokens = new JToken[0];
            CurrentIndex = 0;
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            if (!IsValidate(out var message))
            {
                MessageBox.Show(message, Resources.STR_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SetDisplayResults();
                }
                else
                {
                    textBoxQueryResults.Text = string.Empty;
                    labelResultSummary.Text = string.Empty;
                    MessageBox.Show(Resources.STR_INFO_MODIFY_QUERY, Resources.STR_TITLE_WARNING, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBoxQuery.Focus();
                }
                ValidateButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(Resources.STR_ERROR_PROCESSING_QUERY, ex.Message), Resources.STR_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonNextItem_Click(object sender, EventArgs e)
        {
            CurrentIndex++;
            if (CurrentIndex < SearchTokens.Length)
            {
                SetDisplayResults();
                SetDisplayResultSummary();
            }

            ValidateButtons();
        }

        private void ButtonPreviousItem_Click(object sender, EventArgs e)
        {
            CurrentIndex--;
            if (CurrentIndex >= 0)
            {
                SetDisplayResults();
                SetDisplayResultSummary();
            }

            ValidateButtons();
        }

        private void ComboBoxDisplayFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchTokens != null && SearchTokens.Any())
            {
                SetDisplayResults();
            }
        }

        private void ComboBoxFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchTokens != null && SearchTokens.Any())
            {
                SetDisplayResults();
                ValidateButtons();
            }
        }

        #endregion

        #region Text Change Events

        private void TextBoxInputFilePath_TextChanged(object sender, EventArgs e)
        {
            InputFilePath = textBoxInputFilePath.Text;
        }

        private void TextBoxQuery_TextChanged(object sender, EventArgs e)
        {
            Query = textBoxQuery.Text;
        }

        #endregion

        #region Helper Functions

        private void SetDisplayResultSummary(int count = 0)
        {
            labelResultSummary.Text = comboBoxFiltering.SelectedIndex == 0
                ? string.Format(Resources.STR_INFO_QUERY_RESULTS, CurrentIndex + 1, SearchTokens.Length)
                : string.Format(Resources.STR_INFO_QUERY_RESULTS_LIST, count == 0 ? SearchTokens.Length : count);
        }

        private void SetDisplayResults()
        {
            string jsonContent;
            var selectedFilterIndex = (Filtering)comboBoxFiltering.SelectedIndex;
            var selectedDisplayIndex = comboBoxDisplayFormat.SelectedIndex;

            switch (selectedFilterIndex)
            {
                case Filtering.Pagination:
                    jsonContent = SearchTokens[CurrentIndex].ToString();
                    SetDisplayResultSummary();
                    break;
                case Filtering.List:
                    jsonContent = string.Join(Environment.NewLine, SearchTokens.Select(e => e.ToString()));
                    SetDisplayResultSummary();
                    break;
                case Filtering.UniqueList:
                case Filtering.UniqueListWithCount:
                    {
                        var uniqueItems = SearchTokens.GroupBy(x => x.ToString())
                            .Select(g => new { Text = g.Key, Count = g.Count() });

                        var str = new StringBuilder();
                        foreach (var item in uniqueItems)
                        {
                            str.AppendLine(selectedFilterIndex == Filtering.UniqueList
                                ? item.Text
                                : $"{item.Text.PadRight(75, ' ')}- {item.Count}");
                        }
                        jsonContent = str.ToString();
                        SetDisplayResultSummary(uniqueItems.Count());
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (selectedDisplayIndex == 0)
            {
                textBoxQueryResults.Show();
                textBoxQueryResults.Text = jsonContent;
            }
            else
            {
                webBrowserResults.Show();
                var builder = new StringBuilder();
                builder.AppendLine(selectedDisplayIndex == 1 ? "~~~javascript" : "~~~json");
                builder.AppendLine(jsonContent);
                builder.AppendLine("~~~");

                webBrowserResults.DocumentText = Markdown.ToHtml(builder.ToString(), _syntaxPipeLine);
            }
        }

        private void ValidateButtons()
        {
            textBoxQueryResults.Select(0, 0);
            textBoxQueryResults.ScrollToCaret();
            if (comboBoxFiltering.SelectedIndex != 0)
            {
                buttonPreviousItem.Enabled = false;
                buttonNextItem.Enabled = false;
            }
            else
            {
                buttonPreviousItem.Enabled = CurrentIndex > 0;
                buttonNextItem.Enabled = CurrentIndex < SearchTokens.Length - 1;
            }
        }

        private bool IsValidate(out string message)
        {
            message = string.Empty;
            if (string.IsNullOrWhiteSpace(InputFilePath))
            {
                message = Resources.STR_VAL_INPUT_FILE_EMPTY;
                return false;
            }

            if (!File.Exists(InputFilePath))
            {
                message = Resources.STR_VAL_INPUT_FILE_NOT_FOUND;
                return false;
            }

            DataFileExtension = DataFileType.UNKNOWN;

            if (Enum.TryParse(GetFileExtension(), out DataFileType extension))
                DataFileExtension = extension;

            if (DataFileExtension == DataFileType.UNKNOWN)
            {
                message = Resources.STR_VAL_INPUT_FILE_FORMAT;
                return false;
            }

            if (!string.IsNullOrWhiteSpace(textBoxQuery.Text)) return true;
            message = Resources.STR_VAL_QUERY_EMPTY;
            return false;

        }

        private string GetFileExtension()
        {
            return Path.GetExtension(InputFilePath)?.ToUpper().Substring(1);
        }

        #endregion
    }
}
