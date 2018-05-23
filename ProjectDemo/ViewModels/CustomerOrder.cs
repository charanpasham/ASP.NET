using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectDemo.Models;

namespace ProjectDemo.ViewModels
{
    public class CustomerOrder
    {
        public CustomerOrder()
        {
            CustomerViewModel = new CustomerDetails();
            OrderViewModel = new OrderDetails();
        }
     public CustomerDetails CustomerViewModel { get; set; }
        public OrderDetails OrderViewModel { get; set; }
     
    }
}
