using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Software : Product
    {
        private string version;

        public string Version { get => version; set => version = value; }

        public Software()
        {
            version = "Undefined";
        }

        public Software(string name, double price, int year, int qoh, string version):base(name, price, year, qoh)
        {
            this.version = version;
        }

        public string GetSoftwareInfo()
        {
            return base.GetProductInfo() + "," + version;
        }
    }
}
