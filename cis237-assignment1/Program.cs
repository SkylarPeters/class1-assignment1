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
            UserInterface ui = new UserInterface();
            BeverageCollection bc = new BeverageCollection();
            CSVProcessor csvp = new CSVProcessor();

            int choice = ui.GetUserInput();
            int load = 0;
            while (choice != 5)
            {
                switch (choice)
                {
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
                    case 2:
                        bc.PrintString();
                        break;
                    case 3:
                        bc.Search();
                        break;
                    case 4:
                        bc.Add();
                        break;
                    case 5:
                        break;

                }

                choice = ui.GetUserInput();
            }
        }
    }
}
