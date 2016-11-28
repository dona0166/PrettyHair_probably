using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Email
    {
        public void Subscribe(OrderRepository newest_order)
        {
            newest_order.Fire += new OrderRepository.EventHandler(EmailMessage);
        }
        private void EmailMessage(OrderRepository newest_order, EventArgs e)
        {
            System.Console.WriteLine("This is your new order");
        }
    }
}
