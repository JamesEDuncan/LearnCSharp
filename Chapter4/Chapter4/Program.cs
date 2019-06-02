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
            //9. Write a program that reads an integer number "n" from the console. After that reads "n" numbers from the console and prints their sum.

            int n, 
                tempHoldIntToSum,
                sumOfInts = 0, 
                loopCounter = 0;
            string prsStrErrChk;

            Console.Write("How many numbers would you like to sum? ");
            do
            {
                prsStrErrChk = Console.ReadLine();
                if (int.TryParse(prsStrErrChk, out n))
                {
                    n = int.Parse(prsStrErrChk);
                }
                else
                {
                    Console.Write("Please format your answer as a numeric intiger: ");
                }
            } while (int.TryParse(prsStrErrChk, out n) == false);

            do
            {
                Console.Write("Please enter one of the nubmers you want to sum: ");
                do
                {
                    prsStrErrChk = Console.ReadLine();
                    if (int.TryParse(prsStrErrChk, out tempHoldIntToSum))
                    {
                        tempHoldIntToSum = int.Parse(prsStrErrChk);
                    }
                    else
                    {
                        Console.Write("Please format your answer as a numeric intiger: ");
                    }
                } while (int.TryParse(prsStrErrChk, out tempHoldIntToSum) == false);

                sumOfInts += tempHoldIntToSum;
            } while (++loopCounter < n);

            Console.WriteLine("The sum of the numbers is " + sumOfInts);
        }
    }
}
