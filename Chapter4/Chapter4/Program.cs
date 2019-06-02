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

            int loopCounter = 0;
            int tempInt = 0;
            int sumInt = 0;
            int checkIfRealInt;
            do
            {
                Console.Write("Please enter a nubmer of type int: ");
                string parseString;
                
                do
                {
                    parseString = Console.ReadLine();
                    if (int.TryParse(parseString, out checkIfRealInt))
                    {
                        tempInt = int.Parse(parseString);
                    }
                    else
                    {
                        Console.Write("Try a real int: ");
                    }
                } while (int.TryParse(parseString, out checkIfRealInt) == false);
                
                sumInt += tempInt;

            } while (++loopCounter < 5);

            Console.WriteLine("The sum of the int's is " + sumInt);
        }
    }
}
