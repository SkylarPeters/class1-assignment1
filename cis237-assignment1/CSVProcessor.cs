﻿// Skylar Peters
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
        public bool ImportCsv(string pathToCSVFile, [] )
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    this.ProcessLine(line, , counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void ProcessLine(string line, , int index)
        {
            string[] parts = line.Split(',');

            string id = parts[0];
            string name = parts[1];
            string pack = parts[2];
            decimal price = decimal.Parse(parts[3]);
            bool active = bool.Parse(parts[4]);

            [index] = new (id, name, pack, price, active);
        }
    }
}
