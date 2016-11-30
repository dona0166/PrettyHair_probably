using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    public class EmailRepository
    {
        string content = "";
        public void Subscribe(OrderRepository newest_order)
        {
            newest_order.Fire += new OrderRepository.EventHandler(EmailMessage);
            newest_order.Fire += new OrderRepository.EventHandler(AlertAmount);
            
        }
        public void EmailMessage(OrderRepository newest_order, EventArgs e)
        {
            System.Console.WriteLine(content);
        }

        public void AlertAmount(OrderRepository alert_amount, EventArgs e)
        {
            System.Console.WriteLine("Amount adequate");
        }

        public void EmailContent(Email email, Order myorder)
        {
            if (myorder.OrderCheck)
            {
                content = email.Message = "Order Packed";
                
            }
            else {
                content = email.Message = "Some problem occurred";
            }

        }


    }
}
