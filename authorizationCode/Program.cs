using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorizationCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("autorization");
            
            // enter user end save
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            // enter password end save
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("ERROR MESSAGE !!!");
                    break;
                }
                
                //new name and password
                Console.WriteLine("Enter username :");
                string newName = Console.ReadLine();    

                Console.WriteLine("Enter password :");
                string newPassword = Console.ReadLine();    

                if (name == newName && password == newPassword) {
                    Console.WriteLine("You have registered correctly");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again ");
                }
            }


        }
    }
}
