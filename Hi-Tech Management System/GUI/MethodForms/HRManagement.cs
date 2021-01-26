using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_Tech_Management_System
{
    public partial class HRManagement : Form
    {
        List<Employee> myEmployeeList = new List<Employee>();
        List<User> myUserList = new List<User>();
        User LoggedIn = new User();

        //Methods
        public void RefreshList()
        {

            listViewEmployee.Items.Clear();
            listViewUser.Items.Clear();
            myEmployeeList = EmployeeDA.GetEmployees();
            myUserList = EmployeeDA.GetUsers();
            foreach (User element in myUserList)
            {
                listViewUser.Items.Add(EmployeeDA.ConvertToListViewItemUser(element));
            }

            foreach (Employee element in myEmployeeList)
            {
                listViewEmployee.Items.Add(EmployeeDA.ConvertToListViewItemEmployee(element));
            }
        }
        public Employee ConvertTextEmployee()
        {
            Employee anEmployee = new Employee();
            anEmployee.EmpId = Convert.ToInt32(textBoxEmpID.Text);
            anEmployee.FirstName = textBoxFirstName.Text;
            anEmployee.LastName = textBoxLastName.Text;
            anEmployee.PhoneNumber = Convert.ToInt64(textBoxPhoneNumber.Text);

            Address anAddress = new Address();
            anAddress.StreetNumber = Convert.ToInt32(textBoxStreetNumber.Text);
            anAddress.StreetName = textBoxStreetName.Text;
            anAddress.PostalCode = textBoxPostalCode.Text;
            anAddress.City = textBoxCity.Text;
            anAddress.Province = textBoxProvince.Text;

            anEmployee.Address = anAddress;
            anEmployee.Ssn = Convert.ToInt64(textBoxSSN.Text);
            anEmployee.Salary = Convert.ToDouble(textBoxSalary.Text);

            return anEmployee;
        }
        public User ConvertTextUser()
        {
            User aUser = new User();
            try
            {
                aUser.EmpId = Convert.ToInt32(textBoxEmpID.Text);
            }
            catch(Exception ex) { aUser.EmpId = -1; }
            aUser.FirstName = textBoxFirstName.Text;
            aUser.LastName = textBoxLastName.Text;
            aUser.Username = textBoxUserName.Text;
            aUser.Password = textBoxPassword.Text;
            try
            {
                aUser.Al = (User.EnumAL)Enum.Parse(typeof(User.EnumAL), textBoxAccessLevel.Text);
            }
            catch(Exception ex) { aUser.Al = User.EnumAL.Undefined; }

            return aUser;
        }

        public HRManagement()
        {
            InitializeComponent();
            comboBoxModeSelection.SelectedItem = "Users";
            myEmployeeList = EmployeeDA.GetEmployees();
            myUserList = EmployeeDA.GetUsers();
            RefreshList();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxModeSelection.Text == "Employees")
            {
                EmployeeDA.SetEmployee(ConvertTextEmployee());
            }
            if (comboBoxModeSelection.Text == "Users")
            {
                User aUser = ConvertTextUser();
                aUser.EmpId = EmployeeDA.GetNextUID();
                EmployeeDA.SetUser(aUser);
            }
            RefreshList();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxModeSelection.Text == "Employees")
            {

                EmployeeDA.UpdateEmployee(ConvertTextEmployee());
            }
            if (comboBoxModeSelection.Text == "Users")
            {

                EmployeeDA.UpdateUser(ConvertTextUser());
            }
            RefreshList();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxModeSelection.Text == "Employees")
            {
                EmployeeDA.DeleteEmployee(ConvertTextEmployee());
            }
            if (comboBoxModeSelection.Text == "Users")
            {

                EmployeeDA.DeleteUser(ConvertTextUser());
            }
            RefreshList();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewUser.FocusedItem.Index;

            textBoxEmpID.Text = Convert.ToString(myUserList[index].EmpId);
            textBoxFirstName.Text = myUserList[index].FirstName;
            textBoxLastName.Text = myUserList[index].LastName;
            textBoxUserName.Text = myUserList[index].Username;
            textBoxPassword.Text = "123";
            textBoxAccessLevel.Text = Convert.ToString(myUserList[index].Al);
        }
        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewEmployee.FocusedItem.Index;

            textBoxEmpID.Text = Convert.ToString(myEmployeeList[index].EmpId);
            textBoxFirstName.Text = myEmployeeList[index].FirstName;
            textBoxLastName.Text = myEmployeeList[index].LastName;
            textBoxPhoneNumber.Text = Convert.ToString(myEmployeeList[index].PhoneNumber);
            textBoxSSN.Text = Convert.ToString(myEmployeeList[index].Ssn);
            textBoxSalary.Text = Convert.ToString(myEmployeeList[index].Salary);
            textBoxStreetNumber.Text = Convert.ToString(myEmployeeList[index].Address.StreetNumber);
            textBoxStreetName.Text = myEmployeeList[index].Address.StreetName;
            textBoxPostalCode.Text = myEmployeeList[index].Address.PostalCode;
            textBoxCity.Text = myEmployeeList[index].Address.City;
            textBoxProvince.Text = myEmployeeList[index].Address.Province;
        }
        private void comboBoxModeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control element in Controls)
            {
                if(element is TextBox)
                {
                    element.Visible = false;
                }

                if(element is Label && element != labelModeSelection)
                {
                    element.Visible = false;
                }
                
                if(element is ListView)
                {
                    element.Visible = false;
                }
            }

            if (comboBoxModeSelection.Text == "Users")
            {
                textBoxEmpID.Visible = true;
                labelID.Visible = true;

                textBoxFirstName.Visible = true;
                labelFirstName.Visible = true;

                textBoxLastName.Visible = true;
                labelLastName.Visible = true;

                textBoxUserName.Visible = true;
                labelUserName.Visible = true;

                textBoxPassword.Visible = true;
                labelPassword.Visible = true;

                textBoxAccessLevel.Visible = true;
                labelAccessLevel.Visible = true;

                listViewUser.Visible = true;
            }
            else
            {
                if(comboBoxModeSelection.Text == "Employees")
                {
                    textBoxEmpID.Visible = true;
                    labelID.Visible = true;

                    textBoxFirstName.Visible = true;
                    labelFirstName.Visible = true;

                    textBoxLastName.Visible = true;
                    labelLastName.Visible = true;

                    textBoxPhoneNumber.Visible = true;
                    labelPhoneNumber.Visible = true;

                    textBoxStreetNumber.Visible = true;
                    labelAddress.Visible = true;
                    labelStreetNumber.Visible = true;

                    textBoxStreetName.Visible = true;
                    labelStreetName.Visible = true;

                    textBoxPostalCode.Visible = true;
                    labelPostalCode.Visible = true;

                    textBoxCity.Visible = true;
                    labelCity.Visible = true;

                    textBoxProvince.Visible = true;
                    labelProvince.Visible = true;

                    textBoxSSN.Visible = true;
                    labelSSN.Visible = true;

                    textBoxSalary.Visible = true;
                    labelSalary.Visible = true;

                    listViewEmployee.Visible = true;
                }
            }
        }
    }
}
