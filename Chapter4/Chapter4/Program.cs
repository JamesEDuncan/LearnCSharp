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
            // 7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.

            int x = 0;
            int tempInt = 0;
            int sumInt = 0;
            do
            {
                Console.WriteLine("Please enter a nubmer of type int");
                tempInt = int.Parse(Console.ReadLine());
                sumInt += tempInt;
            } while (++x < 5);

            Console.WriteLine("The sum of the int's is " + sumInt);
        }
    }
}
