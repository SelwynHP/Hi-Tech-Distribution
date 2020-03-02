using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hi_Tech_Management_System
{
    class OrderDA
    {
        static string filePathOrder = Application.StartupPath + @"\order.dat";
        static string filePathTemp = Application.StartupPath + @"\temp.dat";
        static string filePathBackup = Application.StartupPath + @"\backup.dat";

        public static void SetOrder(Order anOrder)
        {
            using (StreamWriter sw = new StreamWriter(filePathOrder, true))
            {
                sw.WriteLine(anOrder.GetOrderInfo());
            }
        }

        public static List<Order> GetOrder()
        {
            List<Order> myOrderList = new List<Order>();
            string line;

            using (StreamReader sr = new StreamReader(filePathOrder))
            {
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] part = line.Split(',');

                    Order anOrder = new Order();
                    anOrder.OrderId = Convert.ToInt32(part[0]);

                    Ordered ordered = new Ordered();
                    ordered.ProductId = Convert.ToInt32(part[1]);
                    ordered.Quantity = Convert.ToInt32(part[2]);

                    anOrder.Ordered = ordered;
                    anOrder.OrderDate = Convert.ToDateTime(part[3]);
                    anOrder.ShipDate = Convert.ToDateTime(part[4]);
                    anOrder.SalesClerkId = Convert.ToInt32(part[5]);
                    anOrder.ClientId = Convert.ToInt32(part[6]);

                    myOrderList.Add(anOrder);

                    line = sr.ReadLine();
                }
            }
            return myOrderList;
        }
        public static ListViewItem ConvertToListViewItemOrder(Order element)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(element.OrderId));
            item.SubItems.Add(Convert.ToString(element.Ordered.ProductId));
            item.SubItems.Add(Convert.ToString(element.Ordered.Quantity));
            item.SubItems.Add(Convert.ToString(element.OrderDate));
            item.SubItems.Add(Convert.ToString(element.ShipDate));
            item.SubItems.Add(Convert.ToString(element.SalesClerkId));
            item.SubItems.Add(Convert.ToString(element.ClientId));

            return item;
        }
        public static void UpdateOrder(Order order)
        {
            List<Order> myOrderList = OrderDA.GetOrder();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Order element in myOrderList)
                {
                    if (element.OrderId != order.OrderId)
                    {
                        sw.WriteLine(element.GetOrderInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathOrder, filePathBackup);
            using (StreamWriter sw = new StreamWriter(filePathOrder, true))
            {
                sw.WriteLine(order.GetOrderInfo());
            }
        }
        public static void DeleteOrder(Order order)
        {
            List<Order> myOrderList = OrderDA.GetOrder();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Order element in myOrderList)
                {
                    if (element.OrderId != order.OrderId)
                    {
                        sw.WriteLine(element.GetOrderInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathOrder, filePathBackup);
        }
    }
}
