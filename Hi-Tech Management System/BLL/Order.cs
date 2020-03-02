using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System
{
    class Order
    {
        private int orderId;
        private Ordered ordered;
        private DateTime orderDate;
        private DateTime shipDate;
        private int salesClerkId;
        private int clientId;

        public int OrderId { get => orderId; set => orderId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime ShipDate { get => shipDate; set => shipDate = value; }
        public int SalesClerkId { get => salesClerkId; set => salesClerkId = value; }
        public Ordered Ordered { get => ordered; set => ordered = value; }
        public int ClientId { get => clientId; set => clientId = value; }

        public Order()
        {
        }

        public Order(int orderId, Ordered ordered, DateTime orderDate, DateTime shipDate, int salesClerkId, int clientId)
        {
            this.orderId = orderId;
            this.ordered = ordered;
            this.orderDate = orderDate;
            this.shipDate = shipDate;
            this.salesClerkId = salesClerkId;
            this.clientId = clientId;
        }

        public string GetOrderInfo()
        {
            return orderId + "," + ordered.GetOrderedInfo() + "," + orderDate + "," + shipDate + "," + salesClerkId + "," + clientId;
        }
    }
}
