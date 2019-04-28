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

            long firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber;

            //first num
            Console.Write("Please enter a number of type int: ");
            string parseString = Console.ReadLine();
            do
            {
                if (long.TryParse(parseString, out firstNumber) == false)
                {
                    Console.Write("Try a real int: ");
                    parseString = Console.ReadLine();
                }
                else
                {
                    firstNumber = long.Parse(parseString);
                }
            } while (long.TryParse(parseString, out firstNumber) == false);

            //second num
            Console.Write("Please enter a number of type int: ");
            parseString = Console.ReadLine();
            do
            {
                if (long.TryParse(parseString, out secondNumber) == false)
                {
                    Console.Write("Try a real int: ");
                    parseString = Console.ReadLine();
                }
                else
                {
                    secondNumber = long.Parse(parseString);
                }
            } while (long.TryParse(parseString, out secondNumber) == false);

            // third num
            Console.Write("Please enter a number of type int: ");
            parseString = Console.ReadLine();
            do
            {
                if (long.TryParse(parseString, out thirdNumber) == false)
                {
                    Console.Write("Try a real int: ");
                    parseString = Console.ReadLine();
                }
                else
                {
                    thirdNumber = long.Parse(parseString);
                }
            } while (long.TryParse(parseString, out thirdNumber) == false);

            // fourth num
            Console.Write("Please enter a number of type int: ");
            parseString = Console.ReadLine();
            do
            {
                if (long.TryParse(parseString, out fourthNumber) == false)
                {
                    Console.Write("Try a real int: ");
                    parseString = Console.ReadLine();
                }
                else
                {
                    fourthNumber = long.Parse(parseString);
                }
            } while (long.TryParse(parseString, out fourthNumber) == false);

            // fifth num
            Console.Write("Please enter a number of type int: ");
            parseString = Console.ReadLine();
            do
            {
                if (long.TryParse(parseString, out fifthNumber) == false)
                {
                    Console.Write("Try a real int: ");
                    parseString = Console.ReadLine();
                }
                else
                {
                    fifthNumber = long.Parse(parseString);
                }
            } while (long.TryParse(parseString, out fifthNumber) == false);

            Console.WriteLine("The sum of those nubmers is {0}.", (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber));
        }
    }
}
