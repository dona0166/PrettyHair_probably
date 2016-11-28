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
            
            try
            {
                
                Console.WriteLine("Choose the operation: (1) Insert new Order, (0) Terminate application:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1" :
                        Console.WriteLine("Insert the Order's parameters:");
                        Console.WriteLine("ID:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Order Date:");
                        DateTime o_date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Delivery Date:");
                        DateTime d_date = Convert.ToDateTime(Console.ReadLine());

                        Core.Order myorder = new Core.Order(id, quantity, o_date, d_date);
                        Core.OrderRepository myorderrepository = new OrderRepository();
                        Core.Email email = new Email();
                        myorderrepository.insertNewOrder(myorder);
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
    }
}
