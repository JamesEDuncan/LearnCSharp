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
            // 4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and
            //the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and
            //the third – a negative fraction.The last two numbers have to be rounded to the second decimal place.
            int hexaInt = 4795556;
            double fractionalPositive = (5555d / 3);
            double negativeFraction = (-3d / 8);
            Console.WriteLine("{0,-10:x}\n{1,-10:n2}\n{2,-10:n2}", hexaInt, fractionalPositive, negativeFraction);
        }
    }
}
