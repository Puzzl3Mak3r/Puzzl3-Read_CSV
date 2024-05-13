using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadCSV
{
    class Program // Guide by 
    {
        static void Main(string[] args)
        {
            //string filePath = "hello.csv";      // get file path [[ Look in ReadCSV/bin/debug ]]
            string filePath = ".csv";
            string[] rawLines = System.IO.File.ReadAllLines(filePath); // turn into 1 super long string

            for (int i = 0; i < rawLines.Length; i++) // Go through each line in csv
            {
                string[] rowData = rawLines[i].Split(','); // Split when theres a comma

                for (int j = 0; j < rowData.Length; j++) // Each "text" in line
                {
                    Console.WriteLine(rowData[j]); // Write each line
                }
            }
        }
    }
}
