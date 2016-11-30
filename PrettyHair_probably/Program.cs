using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;





namespace PrettyHair_probably
{
    
    
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            
            Console.Clear();
            Program myprogram = new Program();

            try
            {
                
                Console.WriteLine("Choose the operation: (1) Insert new Order, (0) Terminate application:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        
                        myprogram.running1();
                        break;
                    
                    case "0" :
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Insert valid parameter");
            }
            Console.ReadKey();



        }
        
        public void running1()
        {
            Console.WriteLine("Insert the Order's parameters:");
            Console.WriteLine("Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Order Date:");
            DateTime o_date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Delivery Date:");
            DateTime d_date = Convert.ToDateTime(Console.ReadLine());

            Core.Order myorder = new Core.Order(quantity, o_date, d_date, true);
            Core.OrderRepository myorderrepository = new Core.OrderRepository();
            Core.Email email = new Core.Email();
            Core.EmailRepository emailrep = new Core.EmailRepository();

            myorderrepository.insertNewOrder(myorder);
            emailrep.Subscribe(myorderrepository);
            emailrep.EmailContent(email, myorder);
        }
    }
}
