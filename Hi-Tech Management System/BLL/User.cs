using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    public class User : Employee
    {
        public enum EnumAL { Admin, MIS_Manager, Sales_Manager, Inventory_Controller, Order_Clerk }

        //private int empId;
        //private string firstName;
        //private string lastName;
        private string username;
        private string password;
        private EnumAL al;

        //public int EmpId { get => empId; set => empId = value; }
        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public EnumAL Al { get => al; set => al = value; }
        

        public User()
        {
            //empId = 0000;
            //firstName = "Undefined";
            //lastName = "Undefined";
            username = "Undefined";
            password = "Undefined";
            al = 0;
        }

        public User(int empId, string firstName, string lastName, string username, string password, EnumAL al) : base(empId, firstName, lastName)
        {
            //this.empId = empId;
            //this.firstName = firstName;
            //this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.al = al;
        }

        public string GetUserInfo()
        {
            string output = EmpId + "," + FirstName + "," + LastName + "," + username + "," + password + "," + al;
            return output;
        }
    }
}
