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
        Beverage myBeverage = new Beverage();

        Beverage[] beverages = new Beverage[4000];

        UserInterface ui = new UserInterface();
        CSVProcessor csvp = new CSVProcessor();

        //*************************
        // Methods
        //*************************
        public void Add(int arraySpace)
        {
            try
            {
                int i = arraySpace;
                string input = "";

                ui.Adding();
                input = Console.ReadLine();

                string[] parts = input.Split(',');

                string id = parts[0];
                string name = parts[1];
                string pack = parts[2];
                decimal price = decimal.Parse(parts[3]);
                bool active = bool.Parse(parts[4]);

                beverages[i] = new Beverage(id, name, pack, price, active);
            }
            catch (Exception e)
            {
                ui.PrintErrorMessage();
                Console.WriteLine(e.ToString());
                Console.WriteLine();
            }
        }

        public void Search()
        {
            int x;
            string entry;
            bool found = false;

            ui.Searching();
            entry = Console.ReadLine();

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
                ui.PrintErrorMessage();
            }
        }

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

        public void CSVLoad()
        {
            string pathToCsv = "../../../datafiles/beverage_list.csv";
            csvp.ImportCsv(pathToCsv, beverages);
        }
    }
}
