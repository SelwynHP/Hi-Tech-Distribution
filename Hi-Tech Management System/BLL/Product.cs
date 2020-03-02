using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Product
    {
        private string name;
        private double price;
        private int year;
        private int qoh;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Year { get => year; set => year = value; }
        public int Qoh { get => qoh; set => qoh = value; }

        public Product()
        {
            name = "Undefined";
            price = 0.00;
            year = 1234;
            qoh = 0000;
        }

        public Product(string name, double price, int year, int qoh)
        {
            this.name = name;
            this.price = price;
            this.year = year;
            this.qoh = qoh;
        }

        public string GetProductInfo()
        {
            return name + "," + price + "," + year + "," + qoh;
        }
    }
}
