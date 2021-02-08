﻿// Skylar Peters
// CIS 237
// 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class UserInterface
    {
        //*************************
        // Methods
        //*************************
        public int GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                this.PrintErrorMessage();

                this.PrintMenu();

                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine("ID \t Name \t Pack \t Price \t Active");
            Console.WriteLine(outputList);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

    }
}
