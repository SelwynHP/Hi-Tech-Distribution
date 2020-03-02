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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            comboBoxProduct.SelectedItem = "Book";
        }
        public static string selectedProduct;
        public static string selectedProductType;
        public void RefreshList()
        {
            if (comboBoxProduct.Text == "Book")
            {
                listViewInventory.Items.Clear();
                List<Book> myBookList = ProductDA.GetBook();
                foreach (Book element in myBookList)
                {
                    listViewInventory.Items.Add(ProductDA.ConvertToListViewItemBook(element));
                }
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    listViewInventory.Items.Clear();
                    List<Software> mySoftwareList = ProductDA.GetSoftware();
                    foreach (Software element in mySoftwareList)
                    {
                        listViewInventory.Items.Add(ProductDA.ConvertToListViewItemSoftware(element));
                    }
                }
            }
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control element in Controls)
            {
                if(element is TextBox)
                {
                    element.Text = "";
                }
            }
            if (comboBoxProduct.Text == "Book")
            {
                textBoxISBN.Enabled = true;
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    textBoxISBN.Enabled = false;
                }
            }
            RefreshList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text == "Book")
            {
                Book aBook = new Book();
                aBook.Isbn = Convert.ToInt32(textBoxISBN.Text);
                aBook.Name = textBoxName.Text;
                aBook.Price = Convert.ToDouble(textBoxPrice.Text);
                aBook.Year = Convert.ToInt32(textBoxYear.Text);
                aBook.Qoh = Convert.ToInt32(textBoxQOH.Text);
                aBook.Category = textBoxCategoryVersion.Text;

                ProductDA.SetBook(aBook);
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    Software aSoftware = new Software();
                    aSoftware.Name = textBoxName.Text;
                    aSoftware.Price = Convert.ToDouble(textBoxPrice.Text);
                    aSoftware.Year = Convert.ToInt32(textBoxYear.Text);
                    aSoftware.Qoh = Convert.ToInt32(textBoxQOH.Text);
                    aSoftware.Version = textBoxCategoryVersion.Text;

                    ProductDA.SetSoftware(aSoftware);

                }
            }
            RefreshList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text == "Book")
            {
                Book aBook = new Book();
                aBook.Isbn = Convert.ToInt32(textBoxISBN.Text);
                aBook.Name = textBoxName.Text;
                aBook.Price = Convert.ToDouble(textBoxPrice.Text);
                aBook.Year = Convert.ToInt32(textBoxYear.Text);
                aBook.Qoh = Convert.ToInt32(textBoxQOH.Text);
                aBook.Category = textBoxCategoryVersion.Text;

                ProductDA.UpdateBook(aBook);
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    Software aSoftware = new Software();
                    aSoftware.Name = textBoxName.Text;
                    aSoftware.Price = Convert.ToDouble(textBoxPrice.Text);
                    aSoftware.Year = Convert.ToInt32(textBoxYear.Text);
                    aSoftware.Qoh = Convert.ToInt32(textBoxQOH.Text);
                    aSoftware.Version = textBoxCategoryVersion.Text;

                    ProductDA.UpdateSoftware(aSoftware);
                }
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text == "Book")
            {
                Book aBook = new Book();
                aBook.Isbn = Convert.ToInt32(textBoxISBN.Text);
                aBook.Name = textBoxName.Text;
                aBook.Price = Convert.ToDouble(textBoxPrice.Text);
                aBook.Year = Convert.ToInt32(textBoxYear.Text);
                aBook.Qoh = Convert.ToInt32(textBoxQOH.Text);
                aBook.Category = textBoxCategoryVersion.Text;

                ProductDA.DeleteBook(aBook);
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    Software aSoftware = new Software();
                    aSoftware.Name = textBoxName.Text;
                    aSoftware.Price = Convert.ToDouble(textBoxPrice.Text);
                    aSoftware.Year = Convert.ToInt32(textBoxYear.Text);
                    aSoftware.Qoh = Convert.ToInt32(textBoxQOH.Text);
                    aSoftware.Version = textBoxCategoryVersion.Text;

                    ProductDA.DeleteSoftware(aSoftware);
                }
            }
            RefreshList();
        }

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewInventory.FocusedItem.Index;

            if (comboBoxProduct.Text == "Book")
            {
                List<Book> myBookList = ProductDA.GetBook();

                textBoxISBN.Text = Convert.ToString(myBookList[index].Isbn);
                textBoxName.Text = myBookList[index].Name;
                textBoxPrice.Text = Convert.ToString(myBookList[index].Price);
                textBoxYear.Text = Convert.ToString(myBookList[index].Year);
                textBoxQOH.Text = Convert.ToString(myBookList[index].Qoh);
                textBoxCategoryVersion.Text = myBookList[index].Category;
            }
            else
            {
                if (comboBoxProduct.Text == "Software")
                {
                    List<Software> mySoftwareList = ProductDA.GetSoftware();

                    textBoxName.Text = mySoftwareList[index].Name;
                    textBoxPrice.Text = Convert.ToString(mySoftwareList[index].Price);
                    textBoxYear.Text = Convert.ToString(mySoftwareList[index].Year);
                    textBoxQOH.Text = Convert.ToString(mySoftwareList[index].Qoh);
                    textBoxCategoryVersion.Text = mySoftwareList[index].Version;
                }
                RefreshList();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxISBN.Text == "")
            {
                selectedProduct = textBoxName.Text;
                selectedProductType = "Software";
            }
            else
            {
                selectedProduct = textBoxISBN.Text;
                selectedProductType = "Book";
            }
            Close();
        }
    }
}
