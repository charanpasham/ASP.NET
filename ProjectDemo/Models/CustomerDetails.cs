using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectDemo.Models
{
    public class CustomerDetails
    {
        public CustomerDetails()
        {
            CustomerCollection = new List<tblCustomers>();
        }
            public List<tblCustomers> CustomerCollection {get; set;}

        public class tblCustomers {

            [DisplayAttribute(Name = "ID")]
                public string ID { get; set; }
            [DisplayAttribute(Name = "Company Name")]
            public string companyName { get; set; }
            [DisplayAttribute(Name = "Contact Name")]
            public string contactName { get; set; }
            [DisplayAttribute(Name = "Contact Title")]
            public string contactTitle { get; set; }
            [DisplayAttribute(Name = "Address")]
            public string address { get; set; }
            [DisplayAttribute(Name = "City")]
            public string city { get; set; }
            [DisplayAttribute(Name = "Country")]
            public string country { get; set; }
            [DisplayAttribute(Name = "Region")]

            public string Region { get; set; }
            [DisplayAttribute(Name = "Postal Code")]

            public string PostalCode { get; set; }
            [DisplayAttribute(Name = "Fax")]
            public string Fax { get; set; }
            [DisplayAttribute(Name = "Mobile")]
            public string Phone { get; set; }
            }
        }
    }

