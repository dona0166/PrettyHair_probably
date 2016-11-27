﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Order(int id, int q, DateTime o_date, DateTime d_date)
        {
            this.Id = id;
            this.Quantity = q;
            this.OrderDate = o_date;
            this.DeliveryDate = d_date;
        }
    }
}