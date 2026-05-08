namespace Final_Project
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TransactionButton = new System.Windows.Forms.RadioButton();
            this.DateButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDisplayTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Salmon;
            this.SearchLabel.Location = new System.Drawing.Point(381, 20);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(299, 38);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Search Transactions";
            // 
            // TransactionButton
            // 
            this.TransactionButton.AutoSize = true;
            this.TransactionButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionButton.Location = new System.Drawing.Point(78, 97);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(231, 30);
            this.TransactionButton.TabIndex = 4;
            this.TransactionButton.TabStop = true;
            this.TransactionButton.Text = "Transaction Number";
            this.TransactionButton.UseVisualStyleBackColor = true;
            // 
            // DateButton
            // 
            this.DateButton.AutoSize = true;
            this.DateButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateButton.Location = new System.Drawing.Point(654, 97);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(78, 30);
            this.DateButton.TabIndex = 5;
            this.DateButton.TabStop = true;
            this.DateButton.Text = "Date";
            this.DateButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(360, 103);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(236, 27);
            this.SearchTextBox.TabIndex = 6;
            // 
            // SearchDisplayTextBox
            // 
            this.SearchDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchDisplayTextBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDisplayTextBox.Location = new System.Drawing.Point(147, 173);
            this.SearchDisplayTextBox.Multiline = true;
            this.SearchDisplayTextBox.Name = "SearchDisplayTextBox";
            this.SearchDisplayTextBox.ReadOnly = true;
            this.SearchDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchDisplayTextBox.Size = new System.Drawing.Size(663, 530);
            this.SearchDisplayTextBox.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Brown;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearButton.Location = new System.Drawing.Point(946, 244);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(123, 48);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "&Clear Form";
            this.toolTip1.SetToolTip(this.ClearButton, "Clear Form for New Search");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Brown;
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReturnButton.Location = new System.Drawing.Point(946, 337);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(123, 48);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "&Main Page";
            this.toolTip1.SetToolTip(this.ReturnButton, "Return to Main Page");
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Info";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Brown;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchButton.Location = new System.Drawing.Point(946, 97);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 48);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchButton, "Clear Form for New Search");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 715);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchDisplayTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.TransactionButton);
            this.Controls.Add(this.SearchLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.RadioButton TransactionButton;
        private System.Windows.Forms.RadioButton DateButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox SearchDisplayTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button SearchButton;
    }
}