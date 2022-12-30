using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * rad * rad;
            Console.WriteLine($"Area of circle is: {area}");
        }
    }
    }

