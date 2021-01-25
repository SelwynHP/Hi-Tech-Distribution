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
    public partial class FormLogin : Form
    {
        List<Employee> myEmployeeList = new List<Employee>();
        List<User> myUserList = new List<User>();
        public static User LoggedIn = new User();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool access = false;
            myUserList = EmployeeDA.GetUsers();
            foreach(User element in myUserList)
            {
                if ((textBoxUserName.Text == element.Username) && (textBoxPassword.Text == element.Password))
                {
                    access = true;
                    LoggedIn = element;
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
                    break;
                }
            }
            if (access == false)
            {
                MessageBox.Show("Error! Invalid User Name and/or Password entered.\nPlease try again.");
            }
        }
    }
}
