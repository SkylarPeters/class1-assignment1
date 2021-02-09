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
    class Program
    {
        static void Main(string[] args)
        {
            // Make new instances of other classes
            UserInterface ui = new UserInterface();
            BeverageCollection bc = new BeverageCollection();

            // Prompt user for input
            int choice = ui.GetUserInput();

            // Variables used in the switch statements
            int load = 0;
            int arraySpace = 3943;

            // Switch statement for the user's choice
            while (choice != 5)
            {
                switch (choice)
                {
                    // Case for loading the csv file
                    case 1:
                        if (load == 0)
                        {
                            bc.CSVLoad();
                            ui.LoadChosen(load);
                            load = 1;
                        }
                        else
                        {
                            ui.LoadChosen(load);
                        }
                        break;
                    // Case for displaying the array
                    case 2:
                        bc.PrintString();
                        break;
                    // Case for searching the array
                    case 3:
                        bc.Search();
                        break;
                    // Case for adding to the array
                    case 4:
                        bc.Add(arraySpace);
                        arraySpace++;
                        break;
                    // Case for exiting the console
                    case 5:
                        break;

                }
                // re-prompt user for input
                choice = ui.GetUserInput();
            }
        }
    }
}
