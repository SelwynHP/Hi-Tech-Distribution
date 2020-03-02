using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hi_Tech_Management_System
{
    class ProductDA
    {
        static string filePathBook = Application.StartupPath + @"\book.dat";
        static string filePathSoftware = Application.StartupPath + @"\software.dat";
        static string filePathTemp = Application.StartupPath + @"\temp.dat";
        static string filePathBackup = Application.StartupPath + @"\backup.dat";


        public static List<Book> GetBook()
        {
            List<Book> myBookList = new List<Book>();
            string line;

            using (StreamReader sr = new StreamReader(filePathBook))
            {
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] part = line.Split(',');

                    Book aBook = new Book();
                    aBook.Isbn = Convert.ToInt32(part[0]);
                    aBook.Name = part[1];
                    aBook.Price = Convert.ToDouble(part[2]);
                    aBook.Year = Convert.ToInt32(part[3]);
                    aBook.Qoh = Convert.ToInt32(part[4]);
                    aBook.Category = part[5];

                    myBookList.Add(aBook);

                    line = sr.ReadLine();
                }
            }
            return myBookList;
        }
        public static void SetBook(Book book)
        {
            using (StreamWriter sw = new StreamWriter(filePathBook,true))
            {
                sw.WriteLine(book.GetBookInfo());
            }
        }
        public static void SetSoftware(Software software)
        {
            using (StreamWriter sw = new StreamWriter(filePathSoftware,true))
            {
                sw.WriteLine(software.GetSoftwareInfo());
            }
        }
        public static List<Software> GetSoftware()
        {
            List<Software> mySoftwareList = new List<Software>();
            string line;

            using (StreamReader sr = new StreamReader(filePathSoftware))
            {
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] part = line.Split(',');

                    Software aSoftware = new Software();
                    aSoftware.Name = part[0];
                    aSoftware.Price = Convert.ToDouble(part[1]);
                    aSoftware.Year = Convert.ToInt32(part[2]);
                    aSoftware.Qoh = Convert.ToInt32(part[3]);
                    aSoftware.Version = part[4];

                    mySoftwareList.Add(aSoftware);

                    line = sr.ReadLine();
                }
            }
            return mySoftwareList;
        }
        public static ListViewItem ConvertToListViewItemBook(Book element)
        {
            ListViewItem item = new ListViewItem(Convert.ToString(element.Isbn));
            item.SubItems.Add(element.Name);
            item.SubItems.Add(Convert.ToString(element.Price));
            item.SubItems.Add(Convert.ToString(element.Year));
            item.SubItems.Add(Convert.ToString(element.Qoh));
            item.SubItems.Add(element.Category);

            return item;
        }
        public static ListViewItem ConvertToListViewItemSoftware(Software element)
        {
            ListViewItem item = new ListViewItem("");
            item.SubItems.Add(element.Name);
            item.SubItems.Add(Convert.ToString(element.Price));
            item.SubItems.Add(Convert.ToString(element.Year));
            item.SubItems.Add(Convert.ToString(element.Qoh));
            item.SubItems.Add(element.Version);

            return item;
        }
        public static void UpdateBook(Book book)
        {
            List<Book> myBookList = ProductDA.GetBook();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Book element in myBookList)
                {
                    if (element.Isbn != book.Isbn)
                    {
                        sw.WriteLine(element.GetBookInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathBook, filePathBackup);
            using (StreamWriter sw = new StreamWriter(filePathBook, true))
            {
                sw.WriteLine(book.GetBookInfo());
            }
        }
        public static void DeleteBook(Book book)
        {
            List<Book> myBookList = ProductDA.GetBook();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Book element in myBookList)
                {
                    if (element.Isbn != book.Isbn)
                    {
                        sw.WriteLine(element.GetBookInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathBook, filePathBackup);
        }
        public static void UpdateSoftware(Software software)
        {
            List<Software> mySoftwareList = ProductDA.GetSoftware();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Software element in mySoftwareList)
                {
                    if (element.Name != software.Name)
                    {
                        sw.WriteLine(element.GetSoftwareInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathSoftware, filePathBackup);
            using (StreamWriter sw = new StreamWriter(filePathSoftware, true))
            {
                sw.WriteLine(software.GetSoftwareInfo());
            }
        }
        public static void DeleteSoftware(Software software)
        {
            List<Software> mySoftwareList = ProductDA.GetSoftware();
            using (StreamWriter sw = new StreamWriter(filePathTemp))
            {
                foreach (Software element in mySoftwareList)
                {
                    if (element.Name != software.Name)
                    {
                        sw.WriteLine(element.GetSoftwareInfo());
                    }
                }
            }
            File.Replace(filePathTemp, filePathSoftware, filePathBackup);
        }
    }
}
