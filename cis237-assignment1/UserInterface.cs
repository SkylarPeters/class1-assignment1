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
            // Print out a menu
            this.PrintMenu();

            // Get the input from the user
            string input = Console.ReadLine();

            // While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                // Print error message
                this.PrintErrorMessage();

                // Print menu again
                this.PrintMenu();

                // Get input from user again
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        /// <summary>
        /// Print the array to the user
        /// </summary>
        /// <param name="outputList">string that displays the list</param>
        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine("ID \t Name \t Pack \t Price \t Active");
            Console.WriteLine(outputList);
        }

        /// <summary>
        /// Print the menu to the user
        /// </summary>
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load File");
            Console.WriteLine("2. Print List");
            Console.WriteLine("3. Search List");
            Console.WriteLine("4. Add New Beverage");
            Console.WriteLine("5. Exit");
        }

        /// <summary>
        /// Print an error message to the user
        /// </summary>
        public void PrintErrorMessage()
        {
            Console.WriteLine("This is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        /// <summary>
        /// Show that the file has been loaded
        /// or stops the file from being loaded again
        /// </summary>
        /// <param name="load">Used to verify if the form has already been loaded</param>
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

        /// <summary>
        /// Print adding instructions to the user
        /// </summary>
        public void Adding()
        {
            Console.WriteLine("Use the following format to add a beverage");
            Console.WriteLine();
            Console.WriteLine("ID,Name,Size,Price,Active");
            Console.WriteLine();
            Console.WriteLine("Example below:");
            Console.WriteLine("132A7,Example Name,750 ml,25.99,True");
        }

        /// <summary>
        /// Print search instructions to the user
        /// </summary>
        public void Searching()
        {
            Console.WriteLine("Enter beverage ID to search for a specific beverage");
        }
    }
}
