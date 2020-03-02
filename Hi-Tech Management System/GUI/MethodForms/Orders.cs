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
    public partial class Orders : Form
    {
        List<Order> myOrderList = new List<Order>();
        User LoggedIn = FormLogin.LoggedIn;
        public Orders()
        {
            InitializeComponent();
            listViewOrder.Items.Clear();
            RefreshList();
        }

        public void RefreshList()
        {

            listViewOrder.Items.Clear();
            myOrderList = OrderDA.GetOrder();

            foreach (Order element in myOrderList)
            {
                listViewOrder.Items.Add(OrderDA.ConvertToListViewItemOrder(element));
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            textBoxSalesClerk.Text = Convert.ToString(LoggedIn.EmpId);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Order anOrder = new Order();

            anOrder.OrderId = Convert.ToInt32(textBoxOrderID.Text);

            Ordered ordered = new Ordered();
            ordered.ProductId = Convert.ToInt32(textBoxProductID.Text);
            ordered.Quantity = Convert.ToInt32(textBoxQuantity.Text);

            anOrder.Ordered = ordered;
            anOrder.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text);
            anOrder.ShipDate = Convert.ToDateTime(dateTimePickerShipDate.Text);
            anOrder.SalesClerkId = LoggedIn.EmpId;

            foreach(Book element in (ProductDA.GetBook()))
            {
                if(element.Isbn == anOrder.Ordered.ProductId)
                {
                    if((element.Qoh - anOrder.Ordered.Quantity) >= 0)
                    {
                        element.Qoh = element.Qoh - anOrder.Ordered.Quantity;
                        ProductDA.UpdateBook(element);
                        OrderDA.SetOrder(anOrder);
                        RefreshList();
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock to complete order.\nAsk Inventory to add more stock before completing order.", "Error!");
                    }
                }
            }
        }

        private void labelSalesClerk_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void labelShipDate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSalesClerk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxShipDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Order anOrder = new Order();

            anOrder.OrderId = Convert.ToInt32(textBoxOrderID.Text);

            Ordered ordered = new Ordered();
            ordered.ProductId = Convert.ToInt32(textBoxProductID.Text);
            ordered.Quantity = Convert.ToInt32(textBoxQuantity.Text);

            anOrder.Ordered = ordered;
            anOrder.OrderDate = DateTime.Now;
            anOrder.ShipDate = Convert.ToDateTime(dateTimePickerShipDate.Text);
            anOrder.SalesClerkId = Convert.ToInt32(textBoxSalesClerk.Text);

            OrderDA.UpdateOrder(anOrder);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Order anOrder = new Order();

            anOrder.OrderId = Convert.ToInt32(textBoxOrderID.Text);

            Ordered ordered = new Ordered();
            ordered.ProductId = Convert.ToInt32(textBoxProductID.Text);
            ordered.Quantity = Convert.ToInt32(textBoxQuantity.Text);

            anOrder.Ordered = ordered;
            anOrder.OrderDate = DateTime.Now;
            anOrder.ShipDate = Convert.ToDateTime(dateTimePickerShipDate.Text);
            anOrder.SalesClerkId = Convert.ToInt32(textBoxSalesClerk.Text);

            OrderDA.DeleteOrder(anOrder);
            RefreshList();
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewOrder.FocusedItem.Index;

            textBoxOrderID.Text = Convert.ToString(myOrderList[index].OrderId);
            textBoxProductID.Text = Convert.ToString(myOrderList[index].Ordered.ProductId);
            textBoxQuantity.Text = Convert.ToString(myOrderList[index].Ordered.Quantity);
            textBoxSalesClerk.Text = Convert.ToString(myOrderList[index].SalesClerkId);
            dateTimePickerOrderDate.Text = Convert.ToString(myOrderList[index].OrderDate);
            dateTimePickerShipDate.Text = Convert.ToString(myOrderList[index].ShipDate);
            textBoxClient.Text = Convert.ToString(myOrderList[index].ClientId);

            List<Client> myClientList = ClientDA.GetClient();
            foreach(Client element in myClientList)
            {
                if(myOrderList[index].ClientId == element.Client_ID)
                {
                    textBoxClientID.Text = Convert.ToString(element.Client_ID);
                    textBoxFirstName.Text = element.FirstName;
                    textBoxLastName.Text = element.LastName;
                }
            }
            
        }

        private void textBoxProductID_MouseClick(object sender, MouseEventArgs e)
        {
            Inventory inventoryselect = new Inventory();
            foreach (Control element in inventoryselect.Controls)
            {
                if(element is Button)
                {
                    element.Enabled = false;
                }
            }
            inventoryselect.buttonOK.Visible = true;
            inventoryselect.buttonOK.Enabled = true;
            inventoryselect.labelSelect.Visible = true;
            inventoryselect.labelSelect.Enabled = true;
            DialogResult result = inventoryselect.ShowDialog();
            if(Inventory.selectedProductType == "Book")
            {
                textBoxProductID.Text = Inventory.selectedProduct;
            }
            else
            {
                if (Inventory.selectedProductType == "Software")
                {
                    textBoxProductID.Text = Inventory.selectedProduct;
                }
            }
            textBoxProductID.Text = Inventory.selectedProduct;

        }
    }
}
