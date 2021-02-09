// Skylar Peters
// CIS 237
// 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237_assignment1
{
    class CSVProcessor
    {
        //*************************
        // Methods
        //*************************
        /// <summary>
        /// Read in a CSV file and use it for populating the beverage array
        /// </summary>
        /// <param name="pathToCSVFile">Path to the csv file</param>
        /// <param name="beverages">Array of beverages to be populated</param>
        /// <returns>Whether it was successful or not</returns>
        public bool ImportCsv(string pathToCSVFile, Beverage[] beverages)
        {
            // Declare the streamReader
            StreamReader streamReader = null;

            try
            {
                // Declare a string for the line
                string line;

                // Create instance of Stream Reader
                streamReader = new StreamReader(pathToCSVFile);

                // Create a counter
                int counter = 0;

                // While reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Proccess the line
                    this.ProcessLine(line, beverages, counter++);
                }
                // Done with file, return true
                return true;
            }
            catch (Exception e)
            {
                // Output the exception and the stacktrace for any exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                // Return false an error occurs
                return false;
            }
            finally
            {
                // Make sure streamReader is closed
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        /// <summary>
        /// Create line to Beverage instance and insert into Beverage array
        /// </summary>
        /// <param name="line">Line to process</param>
        /// <param name="beverages">Array to insert into</param>
        /// <param name="index">Index at which to do the insert</param>
        private void ProcessLine(string line, Beverage[] beverages, int index)
        {
            // Declare parts array for the split pieces of the line
            string[] parts = line.Split(',');

            // Assign each piece to a variable
            string id = parts[0];
            string name = parts[1];
            string pack = parts[2];
            decimal price = decimal.Parse(parts[3]);
            bool active = bool.Parse(parts[4]);

            // Add a new beverage array into the array that was passed in
            beverages[index] = new Beverage(id, name, pack, price, active);
        }
    }
}
