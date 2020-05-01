using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter filename");
                // assign the value of file path in the variable
                var filePath = Console.ReadLine();
                // Check if any parameters were passed in
                if (!string.IsNullOrEmpty(filePath))
                {              
                    // Check if the file exists in the system
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("Processing file..");
                        CalculateExpense calculateExpense = new CalculateExpense(filePath);
                        Console.WriteLine("Expense seperated for each trip and saved to file..");
                    }
                    else
                    {
                        Console.WriteLine("The text file could not be found");
                    }
                }
                else 
                {
                    Console.WriteLine("Please input valid filename");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

    }
}
