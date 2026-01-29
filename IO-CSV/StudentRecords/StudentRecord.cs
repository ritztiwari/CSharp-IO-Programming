// 1️⃣Read a CSV File and Print Data
// ● Read a CSV file containing student details (ID, Name, Age, Marks).
// ● Print each record in a structured format.

using System;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_CSV.StudentRecords
{
    public class StudentRecord
    {
        public static void DisplayRecords(string[] arr)
        {
            System.Console.WriteLine("----Print Record----");
            System.Console.WriteLine($"id is: {arr[0]}\nstudent's name is: {arr[1]}\nage is: {arr[2]}\nmarks obtained is: {arr[3]}");
            System.Console.WriteLine("----End of Record----\n");
        }
        public static void PrintRecord(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = Regex.Split(line, ",");
                        DisplayRecords(arr);
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}