using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Ordered
    {
        private int productId;
        private int quantity;

        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Ordered()
        {

        }
        
        public Ordered(int productId, int quantity)
        {

        }

        public string GetOrderedInfo()
        {
            return productId + "," + quantity;
        }
    }
}
