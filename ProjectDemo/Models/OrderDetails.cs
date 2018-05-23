using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Models
{
    public class OrderDetails
    {

       public OrderDetails()
        {
            OrderCollection = new List<tblOrderDetails>();
        }

        public List<tblOrderDetails> OrderCollection { get; set; }

        public class tblOrderDetails
        {
            public string OrderID { get; set; }
            public string CustomerID { get; set; }
            public string EmployeeID { get; set; }
            public string OrderDate { get; set; }
            public string RequiredDate { get; set; }
            public string ShippedDate { get; set; }
            public string ShipVia { get; set; }
            public string Freight { get; set; }
            public string ShipName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipRegion { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipCountry { get; set; }
        }
    }
}
