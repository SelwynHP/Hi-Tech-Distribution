namespace Hi_Tech_Management_System
{
    partial class HRManagement
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
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxSSN = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeaderempID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAccessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxModeSelection = new System.Windows.Forms.ComboBox();
            this.labelModeSelection = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAccessLevel = new System.Windows.Forms.Label();
            this.textBoxAccessLevel = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxStreetNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelStreetNumber = new System.Windows.Forms.Label();
            this.labelStreetName = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(69, 92);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.ReadOnly = true;
            this.textBoxEmpID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpID.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(175, 92);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.HideSelection = false;
            this.textBoxLastName.Location = new System.Drawing.Point(281, 92);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(69, 137);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 6;
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Location = new System.Drawing.Point(175, 137);
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSN.TabIndex = 7;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(281, 137);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 8;
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderempID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderUserName,
            this.columnHeaderPassword,
            this.columnHeaderAccessLevel});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(12, 253);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(636, 250);
            this.listViewUser.TabIndex = 6;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            this.listViewUser.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderempID
            // 
            this.columnHeaderempID.Text = "Employee ID";
            this.columnHeaderempID.Width = 78;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 123;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 121;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "User Name";
            this.columnHeaderUserName.Width = 125;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.Text = "Password";
            // 
            // columnHeaderAccessLevel
            // 
            this.columnHeaderAccessLevel.Text = "Access Level";
            this.columnHeaderAccessLevel.Width = 119;
            // 
            // comboBoxModeSelection
            // 
            this.comboBoxModeSelection.FormattingEnabled = true;
            this.comboBoxModeSelection.Items.AddRange(new object[] {
            "Users",
            "Employees"});
            this.comboBoxModeSelection.Location = new System.Drawing.Point(36, 38);
            this.comboBoxModeSelection.Name = "comboBoxModeSelection";
            this.comboBoxModeSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModeSelection.TabIndex = 0;
            this.comboBoxModeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxModeSelection_SelectedIndexChanged);
            // 
            // labelModeSelection
            // 
            this.labelModeSelection.AutoSize = true;
            this.labelModeSelection.Location = new System.Drawing.Point(33, 22);
            this.labelModeSelection.Name = "labelModeSelection";
            this.labelModeSelection.Size = new System.Drawing.Size(81, 13);
            this.labelModeSelection.TabIndex = 8;
            this.labelModeSelection.Text = "Mode Selection";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(66, 76);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(172, 76);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(278, 76);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(66, 121);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 12;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Location = new System.Drawing.Point(172, 121);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(29, 13);
            this.labelSSN.TabIndex = 13;
            this.labelSSN.Text = "SSN";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(278, 121);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 14;
            this.labelSalary.Text = "Salary";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(490, 121);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(490, 76);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 18;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(493, 137);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.HideSelection = false;
            this.textBoxUserName.Location = new System.Drawing.Point(493, 92);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 5;
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.HideSelection = false;
            this.listViewEmployee.Location = new System.Drawing.Point(12, 253);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(636, 250);
            this.listViewEmployee.TabIndex = 20;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            this.listViewEmployee.SelectedIndexChanged += new System.EventHandler(this.listViewEmployee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone Number";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SSN";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Salary (Hr)";
            this.columnHeader7.Width = 119;
            // 
            // labelAccessLevel
            // 
            this.labelAccessLevel.AutoSize = true;
            this.labelAccessLevel.Location = new System.Drawing.Point(384, 76);
            this.labelAccessLevel.Name = "labelAccessLevel";
            this.labelAccessLevel.Size = new System.Drawing.Size(71, 13);
            this.labelAccessLevel.TabIndex = 22;
            this.labelAccessLevel.Text = "Access Level";
            // 
            // textBoxAccessLevel
            // 
            this.textBoxAccessLevel.HideSelection = false;
            this.textBoxAccessLevel.Location = new System.Drawing.Point(387, 92);
            this.textBoxAccessLevel.Name = "textBoxAccessLevel";
            this.textBoxAccessLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccessLevel.TabIndex = 4;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(18, 183);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 24;
            this.labelAddress.Text = "Address";
            // 
            // textBoxStreetNumber
            // 
            this.textBoxStreetNumber.Location = new System.Drawing.Point(69, 180);
            this.textBoxStreetNumber.Multiline = true;
            this.textBoxStreetNumber.Name = "textBoxStreetNumber";
            this.textBoxStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreetNumber.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(69, 224);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(150, 224);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(231, 224);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.Location = new System.Drawing.Point(175, 180);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStreetName.TabIndex = 11;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(281, 180);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 12;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(387, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 13;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(493, 180);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvince.TabIndex = 14;
            // 
            // labelStreetNumber
            // 
            this.labelStreetNumber.AutoSize = true;
            this.labelStreetNumber.Location = new System.Drawing.Point(66, 164);
            this.labelStreetNumber.Name = "labelStreetNumber";
            this.labelStreetNumber.Size = new System.Drawing.Size(75, 13);
            this.labelStreetNumber.TabIndex = 32;
            this.labelStreetNumber.Text = "Street Number";
            // 
            // labelStreetName
            // 
            this.labelStreetName.AutoSize = true;
            this.labelStreetName.Location = new System.Drawing.Point(172, 164);
            this.labelStreetName.Name = "labelStreetName";
            this.labelStreetName.Size = new System.Drawing.Size(66, 13);
            this.labelStreetName.TabIndex = 33;
            this.labelStreetName.Text = "Street Name";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(281, 164);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelPostalCode.TabIndex = 34;
            this.labelPostalCode.Text = "Postal Code";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(387, 164);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 35;
            this.labelCity.Text = "City";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(493, 164);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(49, 13);
            this.labelProvince.TabIndex = 36;
            this.labelProvince.Text = "Province";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(312, 224);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // HRManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 515);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelStreetName);
            this.Controls.Add(this.labelStreetNumber);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxStreetName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxStreetNumber);
            this.Controls.Add(this.labelAccessLevel);
            this.Controls.Add(this.textBoxAccessLevel);
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelModeSelection);
            this.Controls.Add(this.comboBoxModeSelection);
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxSSN);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxEmpID);
            this.Name = "HRManagement";
            this.Text = "HRManagement";
            this.Load += new System.EventHandler(this.HRManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSSN;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ComboBox comboBoxModeSelection;
        private System.Windows.Forms.Label labelModeSelection;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderempID;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.ColumnHeader columnHeaderAccessLevel;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label labelAccessLevel;
        private System.Windows.Forms.TextBox textBoxAccessLevel;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxStreetNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelStreetNumber;
        private System.Windows.Forms.Label labelStreetName;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Button buttonExit;
    }
}