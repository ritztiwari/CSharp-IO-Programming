// 6️⃣Modify a CSV File (Update a Value)
// ● Read a CSV file and increase the salary of employees from the "IT" department by
// 10%.
// ● Save the updated records back to a new CSV file.

using System;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_CSV.ModifySalaries
{
    public class ModifySalary
    {
        public static void DisplayRecords(string[] arr)
        {
            System.Console.WriteLine("----Print Record----");
            System.Console.WriteLine($"Department is: {arr[2]}\nSalary is: {arr[3]}");
            System.Console.WriteLine("----End of Record----\n");
        }

        public static void ModifySalaryOfIT(string filePath)
        {
            try
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while((line = reader.ReadLine()) != null)
                    {
                        string[] arr = Regex.Split(line,",");

                        if(arr.Length < 4)
                        {
                            continue;
                        }

                        if (arr[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            double.TryParse(arr[3].Trim(),out double m);
                            m+=m*0.10;
                            System.Console.WriteLine(m);
                            arr[3]=m.ToString();
                            DisplayRecords(arr);

                        }
                    }
                }
            }
            catch(IOException e)
            {
                System.Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("Program Ended");
            }
        }
    }
}