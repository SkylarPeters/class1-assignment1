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

        //*************************
        // Methods
        //*************************
        public void Add()
        {

        }

        public void Search()
        {

        }

        UserInterface ui = new UserInterface();

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

        CSVProcessor csvp = new CSVProcessor();

        public void CSVLoad()
        {
            string pathToCsv = "../../../datafiles/beverage_list.csv";
            csvp.ImportCsv(pathToCsv, beverages);
        }
    }
}
