using System.Windows.Forms;

namespace JsonDataExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelInputFilePath = new System.Windows.Forms.Label();
            this.textBoxInputFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.labelQueryData = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelQueryResults = new System.Windows.Forms.Label();
            this.textBoxQueryResults = new System.Windows.Forms.TextBox();
            this.labelResultSummary = new System.Windows.Forms.Label();
            this.buttonNextItem = new System.Windows.Forms.Button();
            this.buttonPreviousItem = new System.Windows.Forms.Button();
            this.webBrowserResults = new System.Windows.Forms.WebBrowser();
            this.comboBoxDisplayFormat = new System.Windows.Forms.ComboBox();
            this.labelDisplayFormat = new System.Windows.Forms.Label();
            this.labelFiltering = new System.Windows.Forms.Label();
            this.comboBoxFiltering = new System.Windows.Forms.ComboBox();
            this.buttonReloadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInputFilePath
            // 
            this.labelInputFilePath.AutoSize = true;
            this.labelInputFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputFilePath.Location = new System.Drawing.Point(50, 35);
            this.labelInputFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputFilePath.Name = "labelInputFilePath";
            this.labelInputFilePath.Size = new System.Drawing.Size(182, 25);
            this.labelInputFilePath.TabIndex = 0;
            this.labelInputFilePath.Text = "Json Data File Path";
            // 
            // textBoxInputFilePath
            // 
            this.textBoxInputFilePath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxInputFilePath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxInputFilePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputFilePath.Location = new System.Drawing.Point(50, 80);
            this.textBoxInputFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInputFilePath.Name = "textBoxInputFilePath";
            this.textBoxInputFilePath.Size = new System.Drawing.Size(895, 31);
            this.textBoxInputFilePath.TabIndex = 1;
            this.textBoxInputFilePath.TextChanged += new System.EventHandler(this.TextBoxInputFilePath_TextChanged);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(961, 75);
            this.buttonOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(112, 43);
            this.buttonOpenFileDialog.TabIndex = 2;
            this.buttonOpenFileDialog.Text = "Open File";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.ButtonOpenFileDialog_Click);
            // 
            // labelQueryData
            // 
            this.labelQueryData.AutoSize = true;
            this.labelQueryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryData.Location = new System.Drawing.Point(50, 129);
            this.labelQueryData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQueryData.Name = "labelQueryData";
            this.labelQueryData.Size = new System.Drawing.Size(107, 25);
            this.labelQueryData.TabIndex = 0;
            this.labelQueryData.Text = "QueryData";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxQuery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuery.Location = new System.Drawing.Point(50, 174);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(996, 31);
            this.textBoxQuery.TabIndex = 3;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.TextBoxQuery_TextChanged);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute.Location = new System.Drawing.Point(1086, 169);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(112, 43);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Json Files|*.json";
            // 
            // labelQueryResults
            // 
            this.labelQueryResults.AutoSize = true;
            this.labelQueryResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryResults.Location = new System.Drawing.Point(50, 234);
            this.labelQueryResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQueryResults.Name = "labelQueryResults";
            this.labelQueryResults.Size = new System.Drawing.Size(135, 25);
            this.labelQueryResults.TabIndex = 0;
            this.labelQueryResults.Text = "Query Results";
            // 
            // textBoxQueryResults
            // 
            this.textBoxQueryResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxQueryResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQueryResults.Location = new System.Drawing.Point(54, 318);
            this.textBoxQueryResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQueryResults.Multiline = true;
            this.textBoxQueryResults.Name = "textBoxQueryResults";
            this.textBoxQueryResults.ReadOnly = true;
            this.textBoxQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQueryResults.Size = new System.Drawing.Size(1142, 706);
            this.textBoxQueryResults.TabIndex = 7;
            // 
            // labelResultSummary
            // 
            this.labelResultSummary.AutoSize = true;
            this.labelResultSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultSummary.Location = new System.Drawing.Point(50, 271);
            this.labelResultSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultSummary.Name = "labelResultSummary";
            this.labelResultSummary.Size = new System.Drawing.Size(169, 25);
            this.labelResultSummary.TabIndex = 0;
            this.labelResultSummary.Text = "Result Summary";
            // 
            // buttonNextItem
            // 
            this.buttonNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextItem.Location = new System.Drawing.Point(1086, 252);
            this.buttonNextItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNextItem.Name = "buttonNextItem";
            this.buttonNextItem.Size = new System.Drawing.Size(112, 43);
            this.buttonNextItem.TabIndex = 6;
            this.buttonNextItem.Text = "Next >";
            this.buttonNextItem.UseVisualStyleBackColor = true;
            this.buttonNextItem.Click += new System.EventHandler(this.ButtonNextItem_Click);
            // 
            // buttonPreviousItem
            // 
            this.buttonPreviousItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousItem.Location = new System.Drawing.Point(939, 252);
            this.buttonPreviousItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPreviousItem.Name = "buttonPreviousItem";
            this.buttonPreviousItem.Size = new System.Drawing.Size(112, 43);
            this.buttonPreviousItem.TabIndex = 5;
            this.buttonPreviousItem.Text = "< Previous";
            this.buttonPreviousItem.UseVisualStyleBackColor = true;
            this.buttonPreviousItem.Click += new System.EventHandler(this.ButtonPreviousItem_Click);
            // 
            // webBrowserResults
            // 
            this.webBrowserResults.Location = new System.Drawing.Point(50, 318);
            this.webBrowserResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowserResults.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowserResults.Name = "webBrowserResults";
            this.webBrowserResults.Size = new System.Drawing.Size(1144, 708);
            this.webBrowserResults.TabIndex = 8;
            // 
            // comboBoxDisplayFormat
            // 
            this.comboBoxDisplayFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDisplayFormat.FormattingEnabled = true;
            this.comboBoxDisplayFormat.Items.AddRange(new object[] {
            "Text",
            "Javascript",
            "Json"});
            this.comboBoxDisplayFormat.Location = new System.Drawing.Point(777, 255);
            this.comboBoxDisplayFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDisplayFormat.Name = "comboBoxDisplayFormat";
            this.comboBoxDisplayFormat.Size = new System.Drawing.Size(139, 30);
            this.comboBoxDisplayFormat.TabIndex = 9;
            this.comboBoxDisplayFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDisplayFormat_SelectedIndexChanged);
            // 
            // labelDisplayFormat
            // 
            this.labelDisplayFormat.AutoSize = true;
            this.labelDisplayFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayFormat.Location = new System.Drawing.Point(699, 260);
            this.labelDisplayFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDisplayFormat.Name = "labelDisplayFormat";
            this.labelDisplayFormat.Size = new System.Drawing.Size(66, 22);
            this.labelDisplayFormat.TabIndex = 10;
            this.labelDisplayFormat.Text = "Format";
            // 
            // labelFiltering
            // 
            this.labelFiltering.AutoSize = true;
            this.labelFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltering.Location = new System.Drawing.Point(430, 260);
            this.labelFiltering.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltering.Name = "labelFiltering";
            this.labelFiltering.Size = new System.Drawing.Size(74, 22);
            this.labelFiltering.TabIndex = 11;
            this.labelFiltering.Text = "Filtering";
            // 
            // comboBoxFiltering
            // 
            this.comboBoxFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltering.FormattingEnabled = true;
            this.comboBoxFiltering.Items.AddRange(new object[] {
            "Pagination",
            "List",
            "Unique List",
            "Group By Count"});
            this.comboBoxFiltering.Location = new System.Drawing.Point(516, 255);
            this.comboBoxFiltering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFiltering.Name = "comboBoxFiltering";
            this.comboBoxFiltering.Size = new System.Drawing.Size(166, 30);
            this.comboBoxFiltering.TabIndex = 12;
            this.comboBoxFiltering.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFiltering_SelectedIndexChanged);
            // 
            // buttonReloadFile
            // 
            this.buttonReloadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadFile.Location = new System.Drawing.Point(1086, 75);
            this.buttonReloadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReloadFile.Name = "buttonReloadFile";
            this.buttonReloadFile.Size = new System.Drawing.Size(112, 43);
            this.buttonReloadFile.TabIndex = 13;
            this.buttonReloadFile.Text = "Reload File";
            this.buttonReloadFile.UseVisualStyleBackColor = true;
            this.buttonReloadFile.Click += new System.EventHandler(this.ButtonReloadFile_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 1094);
            this.Controls.Add(this.buttonReloadFile);
            this.Controls.Add(this.comboBoxFiltering);
            this.Controls.Add(this.labelFiltering);
            this.Controls.Add(this.labelDisplayFormat);
            this.Controls.Add(this.comboBoxDisplayFormat);
            this.Controls.Add(this.webBrowserResults);
            this.Controls.Add(this.buttonPreviousItem);
            this.Controls.Add(this.buttonNextItem);
            this.Controls.Add(this.labelResultSummary);
            this.Controls.Add(this.textBoxQueryResults);
            this.Controls.Add(this.labelQueryResults);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.labelQueryData);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.textBoxInputFilePath);
            this.Controls.Add(this.labelInputFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JsonDataExplorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputFilePath;
        private System.Windows.Forms.TextBox textBoxInputFilePath;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Label labelQueryData;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReloadFile;
        private System.Windows.Forms.Label labelQueryResults;
        private System.Windows.Forms.TextBox textBoxQueryResults;
        private System.Windows.Forms.Label labelResultSummary;
        private System.Windows.Forms.Button buttonNextItem;
        private System.Windows.Forms.Button buttonPreviousItem;
        private System.Windows.Forms.WebBrowser webBrowserResults;
        private System.Windows.Forms.ComboBox comboBoxDisplayFormat;
        private System.Windows.Forms.Label labelDisplayFormat;
        private System.Windows.Forms.Label labelFiltering;
        private System.Windows.Forms.ComboBox comboBoxFiltering;
    }
}

