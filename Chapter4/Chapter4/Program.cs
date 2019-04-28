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
            // 6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.

            Console.Write("Please type a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please type a different number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The larger number is " + Math.Max(firstNumber, secondNumber) + ".");
        }
    }
}
