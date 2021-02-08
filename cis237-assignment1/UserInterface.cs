// Skylar Peters
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

        public void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        public void LoadChosen(int load)
        {
            if (load == 0)
            {
                Console.WriteLine("File has been loaded");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The file has already been loaded");
                Console.WriteLine("Please choose a different option");
                Console.WriteLine();
            }
        }

        public void Adding()
        {
            Console.WriteLine("Use the following format to add a beverage");
            Console.WriteLine();
            Console.WriteLine("ID,Name,Size,Price,Active");
            Console.WriteLine();
            Console.WriteLine("Example below:");
            Console.WriteLine("132A7,Example Name,750 ml,25.99,True");
        }

        public void Searching()
        {
            Console.WriteLine("Enter beverage ID to search for a specific beverage");
        }
    }
}
