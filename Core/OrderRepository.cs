using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    public class OrderRepository
    {
        private static string connectionString =
            "Server=ealdb1.eal.local;Database=ejl70_db;User Id=ejl70_usr;Password=Baz1nga70;";
        public bool event_state;
        public event EventHandler Fire;
        public EventArgs e = null;
        public delegate void EventHandler(OrderRepository newestOrder, EventArgs e);
        public void insertNewOrder(Order newest_order)
        {
            
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertNewOrder", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@OrderQuantity", newest_order.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@OrderDate", newest_order.OrderDate));
                    cmd.Parameters.Add(new SqlParameter("@DeliveryDate", newest_order.DeliveryDate));

                    cmd.ExecuteNonQuery();
                    FireEvent();

                    
                }
      
                catch(Exception ex)
                {
                    Console.WriteLine("USP" + ex.Message);
                }
                
            }
        }
        
        public void FireEvent()
        {
            
            
            
                Fire(this, e);
                   
            
            
        }
    }
}
 