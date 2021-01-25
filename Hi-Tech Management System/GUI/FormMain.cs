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
    public partial class FormMain : Form
    {
        User LoggedIn = FormLogin.LoggedIn;
        public void NoAccess()
        {
            MessageBox.Show("You do not have access to this form!", "Permission denied!");
        }
        public FormMain()
        {
            InitializeComponent();
            //foreach (Enum element in Enum.GetValues(typeof(User.EnumAL)))
            //{
            //    comboBoxSelection.Items.Add(element);
            //}
        }

        private void comboBoxSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxSelection.SelectedIndex = 0;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (LoggedIn.Al == User.EnumAL.Admin)
            {
                if ((comboBoxSelection.Text == "HR Management"))
                {
                    HRManagement HR = new HRManagement();
                    HR.ShowDialog();
                }
                else
                {
                    if ((comboBoxSelection.Text == "Sales"))
                    {
                        Sales sale = new Sales();
                        sale.ShowDialog();
                    }
                    else
                    {
                        if ((comboBoxSelection.Text == "Inventory"))
                        {
                            Inventory inventory = new Inventory();
                            inventory.ShowDialog();
                        }
                        else
                        {
                            if ((comboBoxSelection.Text == "Orders"))
                            {
                                Orders order = new Orders();
                                order.ShowDialog();
                            }
                            else
                            {
                                NoAccess();
                            }
                        }
                    }
                }
            }
            else
            {
                if ((comboBoxSelection.Text == "HR Management") && (LoggedIn.Al == User.EnumAL.MIS_Manager))
                {
                    HRManagement HR = new HRManagement();
                    HR.ShowDialog();
                }
                else
                {
                    if ((comboBoxSelection.Text == "Sales") && (LoggedIn.Al == User.EnumAL.Sales_Manager))
                    {
                        Sales sale = new Sales();
                        sale.ShowDialog();
                    }
                    else
                    {
                        if ((comboBoxSelection.Text == "Inventory") && (LoggedIn.Al == User.EnumAL.Inventory_Controller))
                        {
                            Inventory inventory = new Inventory();
                            inventory.ShowDialog();
                        }
                        else
                        {
                            if ((comboBoxSelection.Text == "Orders") && (LoggedIn.Al == User.EnumAL.Order_Clerk))
                            {
                                Orders order = new Orders();
                                order.ShowDialog();
                            }
                            else
                            {
                                NoAccess();
                            }
                        }
                    }
                }
            }
            
        }
    }
}
