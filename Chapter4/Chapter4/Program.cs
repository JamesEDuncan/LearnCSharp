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
            //12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …

            double oldSum = 1,
                   newSum,
                   tempSum,
                   n = 2,
                   difference;

            do
            {
                if (n % 2 == 0)
                {
                    newSum = oldSum + (1 / n++);
                }
                else
                {
                    newSum = oldSum - (1 / n++);
                }

                difference = Math.Abs(newSum - oldSum);
                oldSum = newSum;
            } while (difference > .001);

            Console.WriteLine("The sum is {0: .###}", newSum);
        }
    }
}
