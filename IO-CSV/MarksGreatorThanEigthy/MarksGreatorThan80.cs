// 4️⃣Filter Records from CSV
// ● Read a CSV file and filter students who have scored more than 80 marks.
// ● Print only the qualifying records.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_CSV.MarksGreatorThanEighty
{
    public class MarksGreatorThan80
    {
        public static void DisplayStudentRecords(string[] arr)
        {
            System.Console.WriteLine("----Print Record----");
            System.Console.WriteLine($"id is: {arr[0]}\nstudent's name is: {arr[1]}\nage is: {arr[2]}\nmarks obtained is: {arr[3]}");
            System.Console.WriteLine("----End of Record----\n");
        }

        public static void Find(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = Regex.Split(line, @",");

                        if(arr.Length < 4)
                        {
                            continue;
                        }

                        if (int.TryParse(arr[3].Trim(), out int m) && m > 80)
                        {
                            DisplayStudentRecords(arr);
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