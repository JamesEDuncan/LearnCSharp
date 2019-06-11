using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.

            int firstInt,
                secondInt;
            string tempIntString;

            // read first int
            Console.Write("Please enter an integer: ");
            do
            {
                tempIntString = Console.ReadLine();
                if (int.TryParse(tempIntString, out firstInt))
                {
                    firstInt = int.Parse(tempIntString);
                }
                else
                {
                    Console.Write("Please enter a valid int in numerical format: ");
                }
            } while (int.TryParse(tempIntString, out firstInt) == false);

            // read second int
            Console.Write("Please enter a second integer: ");
            do
            {
                tempIntString = Console.ReadLine();
                if (int.TryParse(tempIntString, out secondInt))
                {
                    secondInt = int.Parse(tempIntString);
                }
                else
                {
                    Console.Write("Please enter a valid int in numerical format: ");
                }
            } while (int.TryParse(tempIntString, out secondInt) == false);

            //Solve Problem
            if (firstInt > secondInt)
            {
                int tempInt = secondInt;
                secondInt = firstInt;
                firstInt = tempInt;
                Console.WriteLine("The numbers have been sorted smallest to largest, so firstInt = {0} & secondInt = {1}", firstInt, secondInt);
            }
            else
            {
                Console.WriteLine("The numbers have been sorted smallest to largest, so firstInt = {0} & secondInt = {1}", firstInt, secondInt);
            }
        }
    }
}
