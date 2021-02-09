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
    class BeverageCollection
    {
        // Beverage array instantiation
        Beverage[] beverages = new Beverage[4000];

        // Make new instances of other classes
        UserInterface ui = new UserInterface();
        CSVProcessor csvp = new CSVProcessor();

        //*************************
        // Methods
        //*************************
        /// <summary>
        /// Method to add to the beverages array
        /// </summary>
        /// <param name="arraySpace">position in the array to be changed</param>
        public void Add(int arraySpace)
        {
            // 
            try
            {
                int i = arraySpace;

                string input = "";

                // Directions for the user printed
                ui.Adding();

                // Holds user input
                input = Console.ReadLine();

                // Declare array of parts that will contain the results of splitting the input
                string[] parts = input.Split(',');

                // Assign each part to a variable
                string id = parts[0];
                string name = parts[1];
                string pack = parts[2];
                decimal price = decimal.Parse(parts[3]);
                bool active = bool.Parse(parts[4]);

                // Adds the split input as a new array element
                beverages[i] = new Beverage(id, name, pack, price, active);
            }
            catch (Exception e)
            {
                // Display error message to user
                ui.PrintErrorMessage();
                Console.WriteLine(e.ToString());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method to search the array
        /// There is a Null Reference Exception when an incorrect ID is searched
        /// </summary>
        public void Search()
        {
            int x;
            string entry;
            bool found = false;

            // Search directions for user
            ui.Searching();

            // Store input from user
            entry = Console.ReadLine();

            // Loop to search each element of the array
            for (x = 0; (x < beverages.Length) && (!found); ++x)
            {
                string[] parts = beverages[x].ToString().Split(' ');
                string id = parts[0];

                if (entry == id)
                {
                    Console.WriteLine(beverages[x]);
                    found = true;
                }
            }
            if (found == false)
            {
                // Error message if specified ID was not found
                ui.PrintErrorMessage();
            }
        }

        /// <summary>
        /// Method used to ready the outputString to print the list
        /// </summary>
        public void PrintString()
        {
            string outputString = "";

            foreach (Beverage beverage in beverages)
            {
                if (beverage != null)
                {
                    outputString += beverage.ToString() + Environment.NewLine;
                }
            }

            ui.PrintList(outputString);
        }

        /// <summary>
        /// Method to load the csv file
        /// </summary>
        public void CSVLoad()
        {
            // Path to the csv file
            string pathToCsv = "../../../datafiles/beverage_list.csv";
            csvp.ImportCsv(pathToCsv, beverages);
        }
    }
}
