namespace Hi_Tech_Management_System
{
    partial class Orders
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
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeaderOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderShipDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSalesClerk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSalesClerk = new System.Windows.Forms.Label();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.textBoxSalesClerk = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerShipDate = new System.Windows.Forms.DateTimePicker();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(387, 146);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 72;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(306, 146);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 62;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(225, 146);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 61;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(144, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 60;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(97, 53);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(59, 13);
            this.labelOrderDate.TabIndex = 57;
            this.labelOrderDate.Text = "Order Date";
            this.labelOrderDate.Click += new System.EventHandler(this.labelOrderDate_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderID,
            this.columnHeaderProductID,
            this.columnHeaderQuantity,
            this.columnHeaderOrderDate,
            this.columnHeaderShipDate,
            this.columnHeaderSalesClerk,
            this.columnHeaderClient});
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(96, 175);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(636, 250);
            this.listViewOrder.TabIndex = 55;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeaderOrderID
            // 
            this.columnHeaderOrderID.Text = "OrderID";
            // 
            // columnHeaderProductID
            // 
            this.columnHeaderProductID.Text = "Product ID";
            this.columnHeaderProductID.Width = 88;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.Width = 83;
            // 
            // columnHeaderOrderDate
            // 
            this.columnHeaderOrderDate.Text = "Order Date";
            this.columnHeaderOrderDate.Width = 103;
            // 
            // columnHeaderShipDate
            // 
            this.columnHeaderShipDate.Text = "Ship Date";
            this.columnHeaderShipDate.Width = 89;
            // 
            // columnHeaderSalesClerk
            // 
            this.columnHeaderSalesClerk.Text = "Sales Clerk";
            this.columnHeaderSalesClerk.Width = 85;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Client";
            // 
            // labelSalesClerk
            // 
            this.labelSalesClerk.AutoSize = true;
            this.labelSalesClerk.Location = new System.Drawing.Point(411, 13);
            this.labelSalesClerk.Name = "labelSalesClerk";
            this.labelSalesClerk.Size = new System.Drawing.Size(52, 13);
            this.labelSalesClerk.TabIndex = 54;
            this.labelSalesClerk.Text = "Taken by";
            this.labelSalesClerk.Click += new System.EventHandler(this.labelSalesClerk_Click);
            // 
            // labelShipDate
            // 
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Location = new System.Drawing.Point(94, 94);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(54, 13);
            this.labelShipDate.TabIndex = 53;
            this.labelShipDate.Text = "Ship Date";
            this.labelShipDate.Click += new System.EventHandler(this.labelShipDate_Click);
            // 
            // textBoxSalesClerk
            // 
            this.textBoxSalesClerk.Enabled = false;
            this.textBoxSalesClerk.Location = new System.Drawing.Point(414, 29);
            this.textBoxSalesClerk.Name = "textBoxSalesClerk";
            this.textBoxSalesClerk.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalesClerk.TabIndex = 52;
            this.textBoxSalesClerk.TextChanged += new System.EventHandler(this.textBoxSalesClerk_TextChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(305, 13);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 47;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.Click += new System.EventHandler(this.labelQuantity_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(199, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelFirstName.TabIndex = 46;
            this.labelFirstName.Text = "Product ID";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(93, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(47, 13);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "Order ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.HideSelection = false;
            this.textBoxQuantity.Location = new System.Drawing.Point(308, 29);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 40;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(202, 29);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.ReadOnly = true;
            this.textBoxProductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductID.TabIndex = 39;
            this.textBoxProductID.Text = "Click to Select...";
            this.textBoxProductID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxProductID_MouseClick);
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBoxProductID_TextChanged);
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(96, 29);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderID.TabIndex = 38;
            this.textBoxOrderID.TextChanged += new System.EventHandler(this.textBoxOrderID_TextChanged);
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Enabled = false;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(96, 69);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderDate.TabIndex = 73;
            // 
            // dateTimePickerShipDate
            // 
            this.dateTimePickerShipDate.Location = new System.Drawing.Point(96, 110);
            this.dateTimePickerShipDate.Name = "dateTimePickerShipDate";
            this.dateTimePickerShipDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShipDate.TabIndex = 74;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(517, 13);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(33, 13);
            this.labelClient.TabIndex = 75;
            this.labelClient.Text = "Client";
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(520, 29);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient.TabIndex = 76;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(574, 71);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 82;
            this.labelLastName.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Client ID";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.HideSelection = false;
            this.textBoxLastName.Location = new System.Drawing.Point(577, 87);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 79;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(471, 87);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 78;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Enabled = false;
            this.textBoxClientID.Location = new System.Drawing.Point(365, 87);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientID.TabIndex = 77;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 422);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.dateTimePickerShipDate);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelSalesClerk);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.textBoxSalesClerk);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.textBoxOrderID);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Label labelSalesClerk;
        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.TextBox textBoxSalesClerk;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderID;
        private System.Windows.Forms.ColumnHeader columnHeaderProductID;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderShipDate;
        private System.Windows.Forms.ColumnHeader columnHeaderSalesClerk;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerShipDate;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxClientID;
    }
}