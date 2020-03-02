using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    public class Address
    {
        private int streetNumber;
        private string streetName;
        private string postalCode;
        private string city;
        private string province;

        public int StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }

        public Address()
        {
            streetNumber = 0000;
            streetName = "Undefined";
            postalCode = "Undefined";
            city = "Undefined";
            province = "Undefined";
        }

        public Address(int streetNumber, string streetName, string postalCode, string city, string province)
        {
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.postalCode = postalCode;
            this.city = city;
            this.province = province;
        }

        public string GetAddress()
        {
            string output = streetNumber + "," + streetName + "," + postalCode + "," + city + "," + province;
            return output;
        }
    }
}
