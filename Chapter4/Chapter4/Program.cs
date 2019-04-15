using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            double r = double.Parse(Console.ReadLine());
            double parameter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The parameter is " + parameter + " and the area is " + area + ".");
        }
    }
}
