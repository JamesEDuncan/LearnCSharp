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
            // 5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the
            //    remainder of their division by 5 is 0.Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.

            Console.Write("Please enter an int: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter another int: ");
            int secondInt = int.Parse(Console.ReadLine());

            int divByFiveCount = 0;

            if (firstInt > secondInt)
            {
                do
                {
                    if ((firstInt % 5) == 0)
                    {
                        divByFiveCount++;
                    }
                } while (firstInt-- > secondInt);
            }
            else
            {
                do
                {
                    if ((secondInt % 5) == 0)
                    {
                        divByFiveCount++;
                    }
                } while (secondInt-- > firstInt);
            }
            Console.WriteLine("There are {0} number(s) perfectly divisible by 5 between those integers!", divByFiveCount);
        }
    }
}
