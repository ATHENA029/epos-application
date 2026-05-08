namespace Final_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveSelectionButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.InventoryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartGroupBox = new System.Windows.Forms.GroupBox();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.PointsEarnedLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.ActionGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.NewSaleButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LoyaltyInfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SmallRadio = new System.Windows.Forms.RadioButton();
            this.MediumRadio = new System.Windows.Forms.RadioButton();
            this.LargeRadio = new System.Windows.Forms.RadioButton();
            this.ExtraLargeRadio = new System.Windows.Forms.RadioButton();
            this.FamilyRadio = new System.Windows.Forms.RadioButton();
            this.InventoryGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.CartGroupBox.SuspendLayout();
            this.ActionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Salmon;
            this.TitleLabel.Location = new System.Drawing.Point(381, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(306, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Winter Hot Chocolates";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InventoryGroupBox
            // 
            this.InventoryGroupBox.Controls.Add(this.SizeGroupBox);
            this.InventoryGroupBox.Controls.Add(this.InventoryListView);
            this.InventoryGroupBox.Location = new System.Drawing.Point(24, 68);
            this.InventoryGroupBox.Name = "InventoryGroupBox";
            this.InventoryGroupBox.Size = new System.Drawing.Size(569, 543);
            this.InventoryGroupBox.TabIndex = 1;
            this.InventoryGroupBox.TabStop = false;
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.FamilyRadio);
            this.SizeGroupBox.Controls.Add(this.ExtraLargeRadio);
            this.SizeGroupBox.Controls.Add(this.LargeRadio);
            this.SizeGroupBox.Controls.Add(this.MediumRadio);
            this.SizeGroupBox.Controls.Add(this.SmallRadio);
            this.SizeGroupBox.Controls.Add(this.RemoveSelectionButton);
            this.SizeGroupBox.Controls.Add(this.SizeLabel);
            this.SizeGroupBox.Controls.Add(this.AddtoCartButton);
            this.SizeGroupBox.Controls.Add(this.QuantityTextBox);
            this.SizeGroupBox.Controls.Add(this.QuantityLabel);
            this.SizeGroupBox.Location = new System.Drawing.Point(6, 342);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(544, 195);
            this.SizeGroupBox.TabIndex = 5;
            this.SizeGroupBox.TabStop = false;
            // 
            // RemoveSelectionButton
            // 
            this.RemoveSelectionButton.BackColor = System.Drawing.Color.Brown;
            this.RemoveSelectionButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectionButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveSelectionButton.Location = new System.Drawing.Point(344, 141);
            this.RemoveSelectionButton.Name = "RemoveSelectionButton";
            this.RemoveSelectionButton.Size = new System.Drawing.Size(173, 48);
            this.RemoveSelectionButton.TabIndex = 4;
            this.RemoveSelectionButton.Text = "&Remove From Cart";
            this.toolTip1.SetToolTip(this.RemoveSelectionButton, "Remove From Cart");
            this.RemoveSelectionButton.UseVisualStyleBackColor = false;
            this.RemoveSelectionButton.Click += new System.EventHandler(this.RemoveSelectionButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(6, 27);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(44, 23);
            this.SizeLabel.TabIndex = 6;
            this.SizeLabel.Text = "Size";
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.BackColor = System.Drawing.Color.Brown;
            this.AddtoCartButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCartButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddtoCartButton.Location = new System.Drawing.Point(94, 141);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(123, 48);
            this.AddtoCartButton.TabIndex = 3;
            this.AddtoCartButton.Text = "&Add to Cart";
            this.toolTip1.SetToolTip(this.AddtoCartButton, "Add to Cart");
            this.AddtoCartButton.UseVisualStyleBackColor = false;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(438, 28);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 28);
            this.QuantityTextBox.TabIndex = 2;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(340, 27);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(82, 23);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantity";
            // 
            // InventoryListView
            // 
            this.InventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.InventoryListView.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryListView.FullRowSelect = true;
            this.InventoryListView.GridLines = true;
            this.InventoryListView.HideSelection = false;
            this.InventoryListView.Location = new System.Drawing.Point(6, 23);
            this.InventoryListView.Name = "InventoryListView";
            this.InventoryListView.Size = new System.Drawing.Size(557, 313);
            this.InventoryListView.TabIndex = 0;
            this.InventoryListView.UseCompatibleStateImageBehavior = false;
            this.InventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 411;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price (€)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 141;
            // 
            // CartGroupBox
            // 
            this.CartGroupBox.Controls.Add(this.pictureBox1);
            this.CartGroupBox.Controls.Add(this.PointsLabel);
            this.CartGroupBox.Controls.Add(this.PointsEarnedLabel);
            this.CartGroupBox.Controls.Add(this.TotalAmountLabel);
            this.CartGroupBox.Controls.Add(this.TotalLabel);
            this.CartGroupBox.Controls.Add(this.CartListBox);
            this.CartGroupBox.Location = new System.Drawing.Point(617, 68);
            this.CartGroupBox.Name = "CartGroupBox";
            this.CartGroupBox.Size = new System.Drawing.Size(555, 356);
            this.CartGroupBox.TabIndex = 2;
            this.CartGroupBox.TabStop = false;
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.Location = new System.Drawing.Point(246, 314);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(20, 22);
            this.PointsLabel.TabIndex = 5;
            this.PointsLabel.Text = "0";
            // 
            // PointsEarnedLabel
            // 
            this.PointsEarnedLabel.AutoSize = true;
            this.PointsEarnedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsEarnedLabel.Location = new System.Drawing.Point(34, 313);
            this.PointsEarnedLabel.Name = "PointsEarnedLabel";
            this.PointsEarnedLabel.Size = new System.Drawing.Size(206, 23);
            this.PointsEarnedLabel.TabIndex = 4;
            this.PointsEarnedLabel.Text = "Loyalty Points Earned: ";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.Location = new System.Drawing.Point(110, 275);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(55, 22);
            this.TotalAmountLabel.TabIndex = 3;
            this.TotalAmountLabel.Text = "€0.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(34, 274);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 23);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total:";
            // 
            // CartListBox
            // 
            this.CartListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.HorizontalScrollbar = true;
            this.CartListBox.ItemHeight = 23;
            this.CartListBox.Location = new System.Drawing.Point(16, 23);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(533, 234);
            this.CartListBox.TabIndex = 0;
            // 
            // ActionGroupBox
            // 
            this.ActionGroupBox.Controls.Add(this.ExitButton);
            this.ActionGroupBox.Controls.Add(this.SearchButton);
            this.ActionGroupBox.Controls.Add(this.ReportsButton);
            this.ActionGroupBox.Controls.Add(this.CheckoutButton);
            this.ActionGroupBox.Controls.Add(this.NewSaleButton);
            this.ActionGroupBox.Location = new System.Drawing.Point(617, 459);
            this.ActionGroupBox.Name = "ActionGroupBox";
            this.ActionGroupBox.Size = new System.Drawing.Size(555, 152);
            this.ActionGroupBox.TabIndex = 3;
            this.ActionGroupBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Brown;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(393, 25);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 48);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "Exit Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Brown;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchButton.Location = new System.Drawing.Point(160, 88);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(199, 48);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "&Search Transaction";
            this.toolTip1.SetToolTip(this.SearchButton, "Search Your Transaction");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.BackColor = System.Drawing.Color.Brown;
            this.ReportsButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReportsButton.Location = new System.Drawing.Point(264, 25);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(123, 48);
            this.ReportsButton.TabIndex = 6;
            this.ReportsButton.Text = "&Reports";
            this.toolTip1.SetToolTip(this.ReportsButton, "Show Report");
            this.ReportsButton.UseVisualStyleBackColor = false;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.Color.Brown;
            this.CheckoutButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CheckoutButton.Location = new System.Drawing.Point(135, 25);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(123, 48);
            this.CheckoutButton.TabIndex = 5;
            this.CheckoutButton.Text = "&Check Out";
            this.toolTip1.SetToolTip(this.CheckoutButton, "Complete Sale");
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.BackColor = System.Drawing.Color.Brown;
            this.NewSaleButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSaleButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewSaleButton.Location = new System.Drawing.Point(6, 25);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(123, 48);
            this.NewSaleButton.TabIndex = 4;
            this.NewSaleButton.Text = "&New Sale";
            this.toolTip1.SetToolTip(this.NewSaleButton, "Clear Cart");
            this.NewSaleButton.UseVisualStyleBackColor = false;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSaleButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Info";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // LoyaltyInfoLabel
            // 
            this.LoyaltyInfoLabel.AutoSize = true;
            this.LoyaltyInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoyaltyInfoLabel.ForeColor = System.Drawing.Color.Salmon;
            this.LoyaltyInfoLabel.Location = new System.Drawing.Point(651, 433);
            this.LoyaltyInfoLabel.Name = "LoyaltyInfoLabel";
            this.LoyaltyInfoLabel.Size = new System.Drawing.Size(174, 23);
            this.LoyaltyInfoLabel.TabIndex = 6;
            this.LoyaltyInfoLabel.Text = "1 point per €5 spent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SmallRadio
            // 
            this.SmallRadio.AutoSize = true;
            this.SmallRadio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallRadio.Location = new System.Drawing.Point(7, 59);
            this.SmallRadio.Name = "SmallRadio";
            this.SmallRadio.Size = new System.Drawing.Size(77, 26);
            this.SmallRadio.TabIndex = 7;
            this.SmallRadio.Text = "Small";
            this.SmallRadio.UseVisualStyleBackColor = true;
            this.SmallRadio.CheckedChanged += new System.EventHandler(this.SizeRadio_CheckedChanged);
            // 
            // MediumRadio
            // 
            this.MediumRadio.AutoSize = true;
            this.MediumRadio.Checked = true;
            this.MediumRadio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumRadio.Location = new System.Drawing.Point(7, 91);
            this.MediumRadio.Name = "MediumRadio";
            this.MediumRadio.Size = new System.Drawing.Size(96, 26);
            this.MediumRadio.TabIndex = 8;
            this.MediumRadio.TabStop = true;
            this.MediumRadio.Text = "Medium";
            this.MediumRadio.UseVisualStyleBackColor = true;
            this.MediumRadio.CheckedChanged += new System.EventHandler(this.SizeRadio_CheckedChanged);
            // 
            // LargeRadio
            // 
            this.LargeRadio.AutoSize = true;
            this.LargeRadio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeRadio.Location = new System.Drawing.Point(124, 59);
            this.LargeRadio.Name = "LargeRadio";
            this.LargeRadio.Size = new System.Drawing.Size(76, 26);
            this.LargeRadio.TabIndex = 9;
            this.LargeRadio.Text = "Large";
            this.LargeRadio.UseVisualStyleBackColor = true;
            this.LargeRadio.CheckedChanged += new System.EventHandler(this.SizeRadio_CheckedChanged);
            // 
            // ExtraLargeRadio
            // 
            this.ExtraLargeRadio.AutoSize = true;
            this.ExtraLargeRadio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLargeRadio.Location = new System.Drawing.Point(124, 91);
            this.ExtraLargeRadio.Name = "ExtraLargeRadio";
            this.ExtraLargeRadio.Size = new System.Drawing.Size(123, 26);
            this.ExtraLargeRadio.TabIndex = 10;
            this.ExtraLargeRadio.Text = "Extra Large";
            this.ExtraLargeRadio.UseVisualStyleBackColor = true;
            this.ExtraLargeRadio.CheckedChanged += new System.EventHandler(this.SizeRadio_CheckedChanged);
            // 
            // FamilyRadio
            // 
            this.FamilyRadio.AutoSize = true;
            this.FamilyRadio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyRadio.Location = new System.Drawing.Point(245, 59);
            this.FamilyRadio.Name = "FamilyRadio";
            this.FamilyRadio.Size = new System.Drawing.Size(86, 26);
            this.FamilyRadio.TabIndex = 11;
            this.FamilyRadio.Text = "Family";
            this.FamilyRadio.UseVisualStyleBackColor = true;
            this.FamilyRadio.CheckedChanged += new System.EventHandler(this.SizeRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.LoyaltyInfoLabel);
            this.Controls.Add(this.ActionGroupBox);
            this.Controls.Add(this.CartGroupBox);
            this.Controls.Add(this.InventoryGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winter Hot Chocolates";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InventoryGroupBox.ResumeLayout(false);
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.CartGroupBox.ResumeLayout(false);
            this.CartGroupBox.PerformLayout();
            this.ActionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox InventoryGroupBox;
        private System.Windows.Forms.ListView InventoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button RemoveSelectionButton;
        private System.Windows.Forms.GroupBox CartGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label PointsEarnedLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.GroupBox ActionGroupBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button NewSaleButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label LoyaltyInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton ExtraLargeRadio;
        private System.Windows.Forms.RadioButton LargeRadio;
        private System.Windows.Forms.RadioButton MediumRadio;
        private System.Windows.Forms.RadioButton SmallRadio;
        private System.Windows.Forms.RadioButton FamilyRadio;
    }
}

