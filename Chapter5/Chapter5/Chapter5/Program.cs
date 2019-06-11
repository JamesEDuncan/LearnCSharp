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
            //2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.

            double[] firstNumber = { 0, 1, 2};
            int negNumCount = 0;
            string tempNumParse;
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter a number: ");
                do
                {
                    tempNumParse = Console.ReadLine();
                    if (double.TryParse(tempNumParse, out double a))
                    {
                        firstNumber[i] = double.Parse(tempNumParse);
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }
                } while (double.TryParse(tempNumParse, out double b) == false);
            }

            if (firstNumber[0] < 0)
            {
                negNumCount++;
            }
            if (firstNumber[1] < 0)
            {
                negNumCount++;
            }
            if (firstNumber[2] < 0)
            {
                negNumCount++;
            }
            if (firstNumber[0] == 0 || firstNumber[1] == 0 || firstNumber[2] == 0)
            {
                Console.WriteLine("0");
            }
            else if (negNumCount == 0 || negNumCount == 2)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
