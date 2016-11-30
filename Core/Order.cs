using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool OrderCheck { get; set; }

        public Order(int q, DateTime o_date, DateTime d_date, bool order_check)
        {
            
            this.Quantity = q;
            this.OrderDate = o_date;
            this.DeliveryDate = d_date;
            this.OrderCheck = order_check;
        }
    }
}
