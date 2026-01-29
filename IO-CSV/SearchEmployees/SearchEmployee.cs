// 5️⃣Search for a Record in CSV
// ● Read an employees.csv file and search for an employee by name.
// ● Print their department and salary.

using System;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_CSV.SearchEmployees
{
    internal class SearchEmployee
    {
        internal static void DisplayRecords(string[] arr)
        {
            System.Console.WriteLine("----Print Record----");
            System.Console.WriteLine($"Department is: {arr[2]}\nSalary is: {arr[3]}");
            System.Console.WriteLine("----End of Record----\n");
        }

        internal static void Find(string filePath,string target)
        {
            try
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while((line = reader.ReadLine()) != null)
                    {
                        string[] arr = Regex.Split(line,@",");

                        if(arr.Length < 4)
                        {
                            continue;
                        }

                        if (target.Equals(arr[1],StringComparison.OrdinalIgnoreCase))
                        {
                            DisplayRecords(arr);
                        }
                    } 
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}