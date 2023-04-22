using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());

            int calc;
            string result = string.Empty;

            while (number > 0)
            {
                calc = number % 2;
                number /= 2;
                result = calc.ToString() + result;
            }
            Console.WriteLine("Binary result : {0}", result);
            Console.ReadLine();
        }
    }
}
