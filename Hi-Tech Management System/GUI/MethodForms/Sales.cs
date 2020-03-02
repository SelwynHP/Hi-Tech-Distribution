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
    public partial class Sales : Form
    {
        EmployeeDA employeeDA = new EmployeeDA();
        List<Employee> myEmployeeList = new List<Employee>();
        List<User> myUserList = new List<User>();
        List<Client> myClientList = new List<Client>();
        User LoggedIn = new User();
        ClientDA clientDA = new ClientDA();

        //Methods
        public void RefreshList()
        {
            myClientList = ClientDA.GetClient();

            foreach (Client element in myClientList)
            {
                listViewClient.Items.Add(clientDA.ConvertToListViewItemClient(element));
            }
        }
        public void ExitApp()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        public Sales()
        {
            InitializeComponent();
            listViewClient.Items.Clear();
            RefreshList();
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client aClient = new Client();
            aClient.Client_ID = Convert.ToInt32(textBoxClientID.Text);
            aClient.FirstName = textBoxFirstName.Text;
            aClient.LastName = textBoxLastName.Text;

            ClientDA.SetClient(aClient);

            listViewClient.Items.Clear();
            RefreshList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Client aClient = new Client();
            aClient.Client_ID = Convert.ToInt32(textBoxClientID.Text);
            aClient.FirstName = textBoxFirstName.Text;
            aClient.LastName = textBoxLastName.Text;

            ClientDA.UpdateClient(aClient);
            listViewClient.Items.Clear();
            RefreshList();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewClient.FocusedItem.Index;
            textBoxClientID.Text = Convert.ToString(myClientList[index].Client_ID);
            textBoxFirstName.Text = myClientList[index].FirstName;
            textBoxLastName.Text = myClientList[index].LastName;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Client aClient = new Client();
            aClient.Client_ID = Convert.ToInt32(textBoxClientID.Text);
            aClient.FirstName = textBoxFirstName.Text;
            aClient.LastName = textBoxLastName.Text;

            ClientDA.DeleteClient(aClient);
            listViewClient.Items.Clear();
            RefreshList();
        }
    }
}
