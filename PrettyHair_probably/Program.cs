using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace PrettyHair_probably
{

    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.Clear();
            
            try
            {
                
                Console.WriteLine("Choose the operation: (1) Insert new Order, (0) Terminate application:");
                string choice = Console.Read().ToString();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Insert the Order's parameters:");
                        Console.WriteLine("ID:");
                        int id = Console.Read();
                        Console.WriteLine("Quantity:");
                        int quantity = Console.Read();
                        Console.WriteLine("Order Date:");
                        DateTime o_date = Convert.ToDateTime(Console.Read());
                        Console.WriteLine("Delivery Date:");
                        DateTime d_date = Convert.ToDateTime(Console.Read());
                        




                }
            }
            catch
            {
                Console.WriteLine("Insert valid number");
            }
    
            
            
        }
    }
}
