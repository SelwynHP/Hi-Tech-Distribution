using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    public class Employee
    {
        private int empId;
        private string firstName;
        private string lastName;
        private long phoneNumber;
        private Address address;
        private long ssn;
        private double salary;

        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public long Ssn { get => ssn; set => ssn = value; }
        public double Salary { get => salary; set => salary = value; }
        public Address Address { get => address; set => address = value; }

        public Employee()
        {
            empId = 0000;
            firstName = "Undefined";
            lastName = "Undefined";
            phoneNumber = 5555555555;
            //address
            ssn = 000000000;
            salary = 0;
        }

        public Employee(int empId, string firstName, string lastName)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(int empId,string firstName, string lastName, long phoneNumber, Address address, long ssn, double salary)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.ssn = ssn;
            this.salary = salary;
        }

        public virtual string GetEmployeeInfo()
        {
            string output = empId + "," + firstName + "," + lastName + "," + phoneNumber + "," + address.GetAddress() + "," + ssn + "," + salary;
            return output;
        }
    }
}
