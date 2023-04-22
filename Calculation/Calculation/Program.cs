using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation_of_area_and_volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter length");
            int lengs = int.Parse(Console.ReadLine());

            int area = width * height;
            int volume = width * height * lengs;

            Console.WriteLine("area is " + area );
            Console.WriteLine("volume is " +  volume );

        }
    }
}
