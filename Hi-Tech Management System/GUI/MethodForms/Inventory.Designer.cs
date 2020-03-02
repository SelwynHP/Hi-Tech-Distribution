namespace Hi_Tech_Management_System
{
    partial class Inventory
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnHeaderISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYearPublished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQOH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategoryVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.textBoxCategoryVersion = new System.Windows.Forms.TextBox();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.labelCategoryVersion = new System.Windows.Forms.Label();
            this.labelQOH = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(440, 191);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 86;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(359, 191);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 85;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(278, 191);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 84;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(197, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 83;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(455, 87);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(78, 13);
            this.labelYear.TabIndex = 81;
            this.labelYear.Text = "Year Published";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(349, 87);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 80;
            this.labelPrice.Text = "Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(243, 87);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 79;
            this.labelName.Text = "Name";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(137, 87);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 78;
            this.labelISBN.Text = "ISBN";
            // 
            // listViewInventory
            // 
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderISBN,
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderYearPublished,
            this.columnHeaderQOH,
            this.columnHeaderCategoryVersion});
            this.listViewInventory.GridLines = true;
            this.listViewInventory.Location = new System.Drawing.Point(140, 220);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(636, 250);
            this.listViewInventory.TabIndex = 77;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            this.listViewInventory.SelectedIndexChanged += new System.EventHandler(this.listViewInventory_SelectedIndexChanged);
            // 
            // columnHeaderISBN
            // 
            this.columnHeaderISBN.Text = "ISBN";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            // 
            // columnHeaderYearPublished
            // 
            this.columnHeaderYearPublished.Text = "Year Published";
            this.columnHeaderYearPublished.Width = 107;
            // 
            // columnHeaderQOH
            // 
            this.columnHeaderQOH.Text = "Quantity on Hand";
            this.columnHeaderQOH.Width = 106;
            // 
            // columnHeaderCategoryVersion
            // 
            this.columnHeaderCategoryVersion.Text = "Category/Version";
            this.columnHeaderCategoryVersion.Width = 121;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(458, 103);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 76;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.HideSelection = false;
            this.textBoxPrice.Location = new System.Drawing.Point(352, 103);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 75;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(246, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 74;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(140, 103);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 73;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "Book",
            "Software"});
            this.comboBoxProduct.Location = new System.Drawing.Point(26, 40);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 87;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // textBoxCategoryVersion
            // 
            this.textBoxCategoryVersion.Location = new System.Drawing.Point(670, 103);
            this.textBoxCategoryVersion.Name = "textBoxCategoryVersion";
            this.textBoxCategoryVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoryVersion.TabIndex = 89;
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.HideSelection = false;
            this.textBoxQOH.Location = new System.Drawing.Point(564, 103);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(100, 20);
            this.textBoxQOH.TabIndex = 88;
            // 
            // labelCategoryVersion
            // 
            this.labelCategoryVersion.AutoSize = true;
            this.labelCategoryVersion.Location = new System.Drawing.Point(667, 87);
            this.labelCategoryVersion.Name = "labelCategoryVersion";
            this.labelCategoryVersion.Size = new System.Drawing.Size(89, 13);
            this.labelCategoryVersion.TabIndex = 91;
            this.labelCategoryVersion.Text = "Category/Version";
            // 
            // labelQOH
            // 
            this.labelQOH.AutoSize = true;
            this.labelQOH.Location = new System.Drawing.Point(561, 87);
            this.labelQOH.Name = "labelQOH";
            this.labelQOH.Size = new System.Drawing.Size(90, 13);
            this.labelQOH.TabIndex = 90;
            this.labelQOH.Text = "Quantity on Hand";
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(197, 162);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 92;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Enabled = false;
            this.labelSelect.Location = new System.Drawing.Point(278, 167);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(75, 13);
            this.labelSelect.TabIndex = 93;
            this.labelSelect.Text = "Select an Item";
            this.labelSelect.Visible = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCategoryVersion);
            this.Controls.Add(this.labelQOH);
            this.Controls.Add(this.textBoxCategoryVersion);
            this.Controls.Add(this.textBoxQOH);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.listViewInventory);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxISBN);
            this.Name = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox textBoxCategoryVersion;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.Label labelCategoryVersion;
        private System.Windows.Forms.Label labelQOH;
        private System.Windows.Forms.ColumnHeader columnHeaderISBN;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderYearPublished;
        private System.Windows.Forms.ColumnHeader columnHeaderQOH;
        private System.Windows.Forms.ColumnHeader columnHeaderCategoryVersion;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Label labelSelect;
    }
}