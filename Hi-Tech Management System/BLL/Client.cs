using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Client
    {
        private int client_ID;
        private string firstName;
        private string lastName;

        public int Client_ID { get => client_ID; set => client_ID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Client()
        {
            client_ID = 0000;
            firstName = "Undefined";
            lastName = "Undefined";
        }

        public Client(int client_ID, string firstName, string lastName)
        {
            this.client_ID = client_ID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetClientInfo()
        {
            string output;
            output = client_ID + "," + firstName + "," + lastName;
            return output;
        }
    }
}
