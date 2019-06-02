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
            //8. Write a program that reads five numbers from the console and prints the
            //greatest of them.

            int[] fiveInts = { 0, 1, 2, 3, 4 };
            int largestInt;
            int loopCounter;
            
            loopCounter = 0;
            do
            {
                Console.Write("Please enter a number of type int: ");
                fiveInts[loopCounter] = int.Parse(Console.ReadLine());
            } while (++loopCounter <5);

            loopCounter = 0;
            int tempInt = fiveInts[loopCounter];
            do
            {
                if (tempInt < fiveInts[++loopCounter])
                {
                    tempInt = fiveInts[loopCounter];
                }
            } while (loopCounter < 4);

            largestInt = tempInt;
            Console.WriteLine("The largest number is " + largestInt);

        }
    }
}