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
            //A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the 
            //company and its manager and then prints it on the console.

            string compName, compAddress, compPhoneNum, compFaxNum, compWebSite, compManager, managerFirstName, managerLastName, managerPhoneNum;

            Console.Write("What is the companies name? ");
            compName = Console.ReadLine();
            Console.Write("What is the companies address? ");
            compAddress = Console.ReadLine();
            Console.Write("What is the companies phone #? ");
            compPhoneNum = String.Format("{0:###-###-####}", int.Parse(Console.ReadLine()));
            Console.Write("What is the companies fax #? ");
            compFaxNum = String.Format("{0:###-###-####}", int.Parse(Console.ReadLine()));
            Console.Write("What is the companies website? ");
            compWebSite = Console.ReadLine();
            Console.Write("What is the companies manager? ");
            compManager = Console.ReadLine();

            Console.Write("What is the manager's first name? ");
            managerFirstName = Console.ReadLine();
            Console.Write("What is the manager's last name? ");
            managerLastName = Console.ReadLine();
            Console.Write("What is the manager's phone #? ");
            managerPhoneNum = String.Format("{0:###-###-####}", int.Parse(Console.ReadLine()));

            Console.WriteLine("{0} is located at {1} and can be reached at {2:###-###-####} or fax to {3:###-###-####}. Their website is {4} and is managed by {5}. {6} {7} can be reached at {8:###-###-####}", 
                compName, compAddress, compPhoneNum, compFaxNum, compWebSite, compManager, managerFirstName, managerLastName, managerPhoneNum);
        }
    }
}
