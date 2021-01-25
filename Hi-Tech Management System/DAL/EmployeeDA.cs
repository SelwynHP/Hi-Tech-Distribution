using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hi_Tech_Management_System
{
    class EmployeeDA
    {
        static string filePathEmp = Application.StartupPath + @"\employee.dat";
        static string filePathUser = Application.StartupPath + @"\user.dat";
        static string filePathTemp = Application.StartupPath + @"\temp.dat";
        static string filePathBackup = Application.StartupPath + @"\backup.dat";

        public static List<Employee> GetEmployee()
        {
            
            List<Employee> myEmployeeList = new List<Employee>();
            string line;

                StreamReader sr = new StreamReader(filePathEmp);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] part = line.Split(',');
                    Employee anEmployee = new Employee();

                    anEmployee.EmpId = Convert.ToInt32(part[0]);
                    anEmployee.FirstName = part[1];
                    anEmployee.LastName = part[2];
                    anEmployee.PhoneNumber = Convert.ToInt64(part[3]);

                    Address anAddress = new Address();
                    anAddress.StreetNumber = Convert.ToInt32(part[4]);
                    anAddress.StreetName = part[5];
                    anAddress.PostalCode = part[6];
                    anAddress.City = part[7];
                    anAddress.Province = part[8];

                    anEmployee.Address = anAddress;
                    anEmployee.Ssn = Convert.ToInt64(part[9]);
                    anEmployee.Salary = Convert.ToDouble(part[10]);

                    myEmployeeList.Add(anEmployee);

                    line = sr.ReadLine();
                }
                sr.Close();

            return myEmployeeList;
        }

        public static List<User> GetUsers()
        {
            List<User> myUserList = new List<User>();

            using (StreamReader sr = new StreamReader(filePathUser))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    User aUser = new User();
                    string[] part = line.Split(',');

                    aUser.EmpId = Convert.ToInt32(part[0]);
                    aUser.FirstName = part[1];
                    aUser.LastName = part[2];
                    aUser.Username = part[3];
                    aUser.Password = part[4];
                    aUser.Al = (User.EnumAL)Enum.Parse(typeof(User.EnumAL), part[5]);

                    myUserList.Add(aUser);

                    line = sr.ReadLine();
                }
            }
            return myUserList;
        }
        public static void SetUser(User user)
        {
            using (StreamWriter sw = new StreamWriter(filePathUser, true))
            {
                sw.WriteLine(user.GetUserInfo());
            }
        }

        public static ListViewItem ConvertToListViewItemUser(User element)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(element.EmpId));
            item.SubItems.Add(element.FirstName);
            item.SubItems.Add(element.LastName);
            item.SubItems.Add(element.Username);
            //item.SubItems.Add(element.Password);
            item.SubItems.Add("*******");
            item.SubItems.Add(Convert.ToString(element.Al));
            item.SubItems.Add(Convert.ToString(element.Salary));

            return item;
        }

        public static ListViewItem ConvertToListViewItemEmployee(Employee element)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(element.EmpId));
            item.SubItems.Add(element.FirstName);
            item.SubItems.Add(element.LastName);
            item.SubItems.Add(Convert.ToString(element.PhoneNumber));
            item.SubItems.Add(element.Address.GetAddress());
            item.SubItems.Add(Convert.ToString(element.Ssn));
            item.SubItems.Add(Convert.ToString(element.Salary));

            return item;
        }
        public static void SetEmployee(Employee anEmployee)
        {
            using(StreamWriter sw = new StreamWriter(filePathEmp,true))
            {
                sw.WriteLine(anEmployee.GetEmployeeInfo());
            }
        }
        public static void UpdateEmployee(Employee employee)
        {
            List<Employee> myEmployeeList = EmployeeDA.GetEmployee();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Employee element in myEmployeeList)
                {
                    if (element.EmpId != employee.EmpId)
                    {
                        sw.WriteLine(element.GetEmployeeInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathEmp, filePathBackup);

            using (StreamWriter sw = new StreamWriter(filePathEmp, true))
            {
                sw.WriteLine(employee.GetEmployeeInfo());
            }
                EmployeeDA.SetEmployee(employee);
        }
        public static void DeleteEmployee(Employee employee)
        {
            List<Employee> myEmployeeList = EmployeeDA.GetEmployee();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Employee element in myEmployeeList)
                {
                    if (element.EmpId != employee.EmpId)
                    {
                        sw.WriteLine(element.GetEmployeeInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathEmp, filePathBackup);
        }
        public static void UpdateUser(User user)
        {
            List<User> myUserList = EmployeeDA.GetUsers();

            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach(User element in myUserList)
                {
                    if (element.EmpId != user.EmpId)
                    {
                        sw.WriteLine(element.GetUserInfo());
                    }
                }
            }

            File.Replace(filePathTemp, filePathUser, filePathBackup);

            using (StreamWriter sw = new StreamWriter(filePathUser, true))
            {
                sw.WriteLine(user.GetUserInfo());
            }
                EmployeeDA.SetUser(user);
        }
        public static void DeleteUser(User user)
        {
            List<User> myUserList = EmployeeDA.GetUsers();

            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (User element in myUserList)
                {
                    if (element.EmpId != user.EmpId)
                    {
                        sw.WriteLine(element.GetUserInfo());
                    }
                }
            }

            File.Replace(filePathTemp, filePathUser, filePathBackup);
        }
    }
}
