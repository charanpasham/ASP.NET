using System;
using System.Data.SqlClient;
using System.Data;
namespace ProjectDemo.DAL
{
    public class DataAccess
    {
        String Connection; 
        public DataAccess()
        {
             Connection = "Data Source = DESKTOP-4SD4DO0; Initial Catalog = Northwind; Integrated Security = True";
        }

        public DataTable GetDALCustomers(){
            
            DataTable dtCustomers = new DataTable();

            //Create and open connection first and dispose it after we are done with it. 
            using(SqlConnection con = new SqlConnection(Connection)){

                //open connection here.
                con.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Select * from Customers";
                command.CommandType = CommandType.Text; 

                //Creat a DataAdapter and DataSet 
                using (SqlDataAdapter da = new SqlDataAdapter(command)){

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dtCustomers = ds.Tables[0];
                }



            }

            return dtCustomers; 
        }


        public DataTable GetDALOrders()
        {

            DataTable dtOrders = new DataTable();

            //Create and open connection first and dispose it after we are done with it. 
            using (SqlConnection con = new SqlConnection(Connection))
            {

                //open connection here.
                con.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Select * from Orders";
                command.CommandType = CommandType.Text;

                //Creat a DataAdapter and DataSet 
                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dtOrders = ds.Tables[0];
                }



            }

            return dtOrders;
        }
    }
}
