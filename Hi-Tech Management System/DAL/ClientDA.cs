using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hi_Tech_Management_System
{
    class ClientDA
    {
        static string filePathClient = Application.StartupPath + @"\client.dat";
        static string filePathTemp = Application.StartupPath + @"\temp.dat";
        static string filePathBackup = Application.StartupPath + @"\backup.dat";

        public static void SetClient(List<Client> myClientList)
        {
            using (StreamWriter sw = new StreamWriter(filePathClient, true))
            {
                foreach(Client element in myClientList)
                {
                    sw.WriteLine(element.GetClientInfo());
                }
            }
        }

        public static void SetClient(Client aClient)
        {
            using (StreamWriter sw = new StreamWriter(filePathClient, true))
            {
                sw.WriteLine(aClient.GetClientInfo());
            }
        }
        public ListViewItem ConvertToListViewItemClient(Client element)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(element.Client_ID));
            item.SubItems.Add(element.FirstName);
            item.SubItems.Add(element.LastName);

            return item;
        }
        public static void UpdateClient(Client client)
        {
            List<Client> myClientList = ClientDA.GetClient();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach(Client element in myClientList)
                {
                    if (element.Client_ID != client.Client_ID)
                    {
                        sw.WriteLine(element.GetClientInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathClient, filePathBackup);
            using (StreamWriter sw = new StreamWriter(filePathClient,true))
            {
                sw.WriteLine(client.GetClientInfo());
            }
        }
        public static List<Client> GetClient()
        {
            
            List<Client> myClientList = new List<Client>();
            string line;

            if (File.Exists(filePathClient))
            {
                StreamReader sr = new StreamReader(filePathClient);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] part = line.Split(',');
                    Client aClient = new Client();

                    aClient.Client_ID = Convert.ToInt32(part[0]);
                    aClient.FirstName = part[1];
                    aClient.LastName = part[2];

                    myClientList.Add(aClient);

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            return myClientList;
        }
        public static void DeleteClient(Client client)
        {
            List<Client> myClientList = ClientDA.GetClient();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Client element in myClientList)
                {
                    if (element.Client_ID != client.Client_ID)
                    {
                        sw.WriteLine(element.GetClientInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathClient, filePathBackup);
        }
    }
}
