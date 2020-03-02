using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Book : Product
    {
        private int isbn;
        private string category;

        public int Isbn { get => isbn; set => isbn = value; }
        public string Category { get => category; set => category = value; }

        public Book()
        {
            isbn = 0000;
            category = "Undefined";
        }

        public Book(int isbn, string name, double price, int year, int qoh, string category):base(name,price,year,qoh)
        {
            this.isbn = isbn;
            this.category = category;
        }

        public string GetBookInfo()
        {
            return isbn +  "," + base.GetProductInfo() + "," + category;
        }
    }
}
