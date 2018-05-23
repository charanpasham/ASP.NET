using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Repository;
using ProjectDemo.Models;
using ProjectDemo.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectDemo.Controllers
{
    public class CustomerOrdersController : Controller
    {
        RepositoryPatt rpPat = new RepositoryPatt();
        // GET: /<controller>/
        public IActionResult Index()
        {
            CustomerDetails cus = new CustomerDetails();
            cus = rpPat.GetCustomers();
            return View(cus);
        }
        public IActionResult EditCustomers(String id)
        {
           CustomerOrder od =  rpPat.EditDetails(id);

            return View(od);
        }
    }
}
