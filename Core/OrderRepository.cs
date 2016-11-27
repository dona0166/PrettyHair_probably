using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    class OrderRepository
    {
        private static string connectionString =
            "Server=ealdb1.eal.local;Database=ejl70_db;User Id=ejl70_usr;Password=Baz1nga70;";
        
        public void insertNewOrder(Order newest_order)
        {
            
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertNewOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id", newest_order.Id));
                    cmd.Parameters.Add(new SqlParameter("@quantity", newest_order.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@order_date", newest_order.OrderDate));
                    cmd.Parameters.Add(new SqlParameter("@delivery_date", newest_order.DeliveryDate));

                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine("USP" + e.Message);
                }
                
            }
        }
    }
}
