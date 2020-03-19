﻿namespace JsonDataExplorer
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
            this.SuspendLayout();
            // 
            // labelInputFilePath
            // 
            this.labelInputFilePath.AutoSize = true;
            this.labelInputFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputFilePath.Location = new System.Drawing.Point(33, 23);
            this.labelInputFilePath.Name = "labelInputFilePath";
            this.labelInputFilePath.Size = new System.Drawing.Size(152, 15);
            this.labelInputFilePath.TabIndex = 0;
            this.labelInputFilePath.Text = "Json or Xml Data File Path";
            // 
            // textBoxInputFilePath
            // 
            this.textBoxInputFilePath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputFilePath.Location = new System.Drawing.Point(36, 49);
            this.textBoxInputFilePath.Name = "textBoxInputFilePath";
            this.textBoxInputFilePath.Size = new System.Drawing.Size(665, 23);
            this.textBoxInputFilePath.TabIndex = 1;
            this.textBoxInputFilePath.TextChanged += new System.EventHandler(this.textBoxInputFilePath_TextChanged);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(724, 49);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFileDialog.TabIndex = 2;
            this.buttonOpenFileDialog.Text = "Open File";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.ButtonOpenFileDialog_Click);
            // 
            // labelQueryData
            // 
            this.labelQueryData.AutoSize = true;
            this.labelQueryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryData.Location = new System.Drawing.Point(33, 84);
            this.labelQueryData.Name = "labelQueryData";
            this.labelQueryData.Size = new System.Drawing.Size(65, 15);
            this.labelQueryData.TabIndex = 0;
            this.labelQueryData.Text = "QueryData";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuery.Location = new System.Drawing.Point(36, 110);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(665, 23);
            this.textBoxQuery.TabIndex = 3;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExecute.Location = new System.Drawing.Point(724, 110);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Json Files|*.json|XML Files|*.xml";
            // 
            // labelQueryResults
            // 
            this.labelQueryResults.AutoSize = true;
            this.labelQueryResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueryResults.Location = new System.Drawing.Point(33, 169);
            this.labelQueryResults.Name = "labelQueryResults";
            this.labelQueryResults.Size = new System.Drawing.Size(83, 15);
            this.labelQueryResults.TabIndex = 0;
            this.labelQueryResults.Text = "Query Results";
            // 
            // textBoxQueryResults
            // 
            this.textBoxQueryResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxQueryResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQueryResults.Location = new System.Drawing.Point(36, 207);
            this.textBoxQueryResults.Multiline = true;
            this.textBoxQueryResults.Name = "textBoxQueryResults";
            this.textBoxQueryResults.ReadOnly = true;
            this.textBoxQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQueryResults.Size = new System.Drawing.Size(763, 451);
            this.textBoxQueryResults.TabIndex = 7;
            // 
            // labelResultSummary
            // 
            this.labelResultSummary.AutoSize = true;
            this.labelResultSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultSummary.Location = new System.Drawing.Point(167, 169);
            this.labelResultSummary.Name = "labelResultSummary";
            this.labelResultSummary.Size = new System.Drawing.Size(98, 15);
            this.labelResultSummary.TabIndex = 0;
            this.labelResultSummary.Text = "Result Summary";
            // 
            // buttonNextItem
            // 
            this.buttonNextItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextItem.Location = new System.Drawing.Point(724, 164);
            this.buttonNextItem.Name = "buttonNextItem";
            this.buttonNextItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNextItem.TabIndex = 6;
            this.buttonNextItem.Text = "Next >";
            this.buttonNextItem.UseVisualStyleBackColor = true;
            this.buttonNextItem.Click += new System.EventHandler(this.buttonNextItem_Click);
            // 
            // buttonPreviousItem
            // 
            this.buttonPreviousItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousItem.Location = new System.Drawing.Point(626, 164);
            this.buttonPreviousItem.Name = "buttonPreviousItem";
            this.buttonPreviousItem.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousItem.TabIndex = 5;
            this.buttonPreviousItem.Text = "< Previous";
            this.buttonPreviousItem.UseVisualStyleBackColor = true;
            this.buttonPreviousItem.Click += new System.EventHandler(this.buttonPreviousItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 711);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JsonDataExplorer";
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
        private System.Windows.Forms.Label labelQueryResults;
        private System.Windows.Forms.TextBox textBoxQueryResults;
        private System.Windows.Forms.Label labelResultSummary;
        private System.Windows.Forms.Button buttonNextItem;
        private System.Windows.Forms.Button buttonPreviousItem;
    }
}
