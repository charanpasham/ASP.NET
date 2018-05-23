using System;
using ProjectDemo.Models;
using ProjectDemo.DAL;
using System.Data;
using ProjectDemo.ViewModels;
namespace ProjectDemo.Repository
{
    public class RepositoryPatt
    {
        DataAccess dal; 
        public RepositoryPatt()
        {
            dal = new DataAccess();
        }
        public CustomerDetails GetCustomers(){
            CustomerDetails customer = new CustomerDetails();
            DataTable dtCustomer = new DataTable();
            dtCustomer = dal.GetDALCustomers();
            foreach (DataRow dr in dtCustomer.Rows)
            {
                customer.CustomerCollection.Add(new CustomerDetails.tblCustomers()
                {
                    ID = dr["CustomerID"].ToString(), 
                    companyName = dr["CompanyName"].ToString(),
                    contactName = dr["ContactName"].ToString(),
                    contactTitle = dr["ContactTitle"].ToString(),
                    address = dr["Address"].ToString(),
                    city = dr["City"].ToString(),
                    country =  dr["Country"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    PostalCode = dr["PostalCode"].ToString(),
                    Region = dr["Region"].ToString(),
                    Fax =  dr["Fax"].ToString()
                });
                 }

            return customer;
        }

        public OrderDetails GetOrders()
        {
            OrderDetails order = new OrderDetails();

            DataTable dtOrders = new DataTable();

            dtOrders = dal.GetDALOrders(); 
            foreach(DataRow dr in dtOrders.Rows)
            {
                order.OrderCollection.Add(new OrderDetails.tblOrderDetails()
                {
                    OrderID = dr["OrderID"].ToString(), 
                    CustomerID = dr["CustomerID"].ToString(),
                    EmployeeID = dr["EmployeeID"].ToString(),
                    OrderDate = dr["OrderDate"].ToString(),
                     RequiredDate = dr["RequiredDate"].ToString(),
                    ShippedDate = dr["ShippedDate"].ToString(),
                    ShipVia= dr["ShipVia"].ToString(),
                    Freight= dr["Freight"].ToString(),
                    ShipName= dr["ShipName"].ToString(),
                    ShipAddress = dr["ShipAddress"].ToString(),
                    ShipCity = dr["ShipCity"].ToString(),
                    ShipRegion = dr["ShipRegion"].ToString(),
                      ShipPostalCode = dr["ShipPostalCode"].ToString(),
                    ShipCountry= dr["ShipCountry"].ToString(),
                });
                    
            }
            return order;
        }

        public CustomerOrder EditDetails(string id)
        {

            CustomerOrder VM = new CustomerOrder();

            VM.CustomerViewModel.CustomerCollection = GetCustomers().CustomerCollection;
            VM.OrderViewModel.OrderCollection = GetOrders().OrderCollection;
            VM.CustomerViewModel.CustomerCollection.RemoveAll(x => x.ID != id);
            VM.OrderViewModel.OrderCollection.RemoveAll(x => x.CustomerID != id);
         
            
            return VM;

        }
    }
}
