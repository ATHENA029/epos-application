namespace Final_Project
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.ReportLabel = new System.Windows.Forms.Label();
            this.SalesReportButton = new System.Windows.Forms.RadioButton();
            this.StockReportButton = new System.Windows.Forms.RadioButton();
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.StockGroupBox = new System.Windows.Forms.GroupBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SalesGroupBox.SuspendLayout();
            this.StockGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.ForeColor = System.Drawing.Color.Salmon;
            this.ReportLabel.Location = new System.Drawing.Point(533, 25);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(123, 38);
            this.ReportLabel.TabIndex = 2;
            this.ReportLabel.Text = "Reports";
            // 
            // SalesReportButton
            // 
            this.SalesReportButton.AutoSize = true;
            this.SalesReportButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportButton.Location = new System.Drawing.Point(154, 90);
            this.SalesReportButton.Name = "SalesReportButton";
            this.SalesReportButton.Size = new System.Drawing.Size(153, 30);
            this.SalesReportButton.TabIndex = 3;
            this.SalesReportButton.TabStop = true;
            this.SalesReportButton.Text = "Sales Report";
            this.SalesReportButton.UseVisualStyleBackColor = true;
            this.SalesReportButton.CheckedChanged += new System.EventHandler(this.SalesRadioButton_CheckedChanged);
            // 
            // StockReportButton
            // 
            this.StockReportButton.AutoSize = true;
            this.StockReportButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockReportButton.Location = new System.Drawing.Point(710, 90);
            this.StockReportButton.Name = "StockReportButton";
            this.StockReportButton.Size = new System.Drawing.Size(156, 30);
            this.StockReportButton.TabIndex = 4;
            this.StockReportButton.TabStop = true;
            this.StockReportButton.Text = "Stock Report";
            this.StockReportButton.UseVisualStyleBackColor = true;
            this.StockReportButton.CheckedChanged += new System.EventHandler(this.StockRadioButton_CheckedChanged);
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.SalesTextBox);
            this.SalesGroupBox.Location = new System.Drawing.Point(50, 154);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(539, 535);
            this.SalesGroupBox.TabIndex = 5;
            this.SalesGroupBox.TabStop = false;
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTextBox.Location = new System.Drawing.Point(6, 21);
            this.SalesTextBox.Multiline = true;
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.ReadOnly = true;
            this.SalesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SalesTextBox.Size = new System.Drawing.Size(515, 508);
            this.SalesTextBox.TabIndex = 0;
            // 
            // StockGroupBox
            // 
            this.StockGroupBox.Controls.Add(this.StockTextBox);
            this.StockGroupBox.Location = new System.Drawing.Point(662, 154);
            this.StockGroupBox.Name = "StockGroupBox";
            this.StockGroupBox.Size = new System.Drawing.Size(539, 535);
            this.StockGroupBox.TabIndex = 6;
            this.StockGroupBox.TabStop = false;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(18, 21);
            this.StockTextBox.Multiline = true;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.ReadOnly = true;
            this.StockTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StockTextBox.Size = new System.Drawing.Size(515, 508);
            this.StockTextBox.TabIndex = 1;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Brown;
            this.ReturnButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReturnButton.Location = new System.Drawing.Point(994, 82);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(123, 48);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "&Main Page";
            this.toolTip1.SetToolTip(this.ReturnButton, "Go Back to Main Page");
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Info";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 722);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.StockGroupBox);
            this.Controls.Add(this.SalesGroupBox);
            this.Controls.Add(this.StockReportButton);
            this.Controls.Add(this.SalesReportButton);
            this.Controls.Add(this.ReportLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.SalesGroupBox.ResumeLayout(false);
            this.SalesGroupBox.PerformLayout();
            this.StockGroupBox.ResumeLayout(false);
            this.StockGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.RadioButton SalesReportButton;
        private System.Windows.Forms.RadioButton StockReportButton;
        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.GroupBox StockGroupBox;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}