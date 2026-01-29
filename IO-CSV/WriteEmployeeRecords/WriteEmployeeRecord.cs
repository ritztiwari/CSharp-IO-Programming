// 2️⃣Write Data to a CSV File
// ● Create a CSV file with employee details (ID, Name, Department, Salary).
// ● Write at least 5 records to the file.

using System;

namespace CSharp_IO_Stream.IO_CSV.WriteEmployeeRecords
{
    public class WriteEmployeeRecord
    {
        public static void WriteRecord(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write CSV Header
                    writer.WriteLine("ID,Name,Department,Salary");

                    // Write Employee Records
                    writer.WriteLine("101,Rishabh Tiwari,IT,75000");
                    writer.WriteLine("102,Anita Sharma,HR,62000");
                    writer.WriteLine("103,Rahul Verma,Finance,71000");
                    writer.WriteLine("104,Priya Singh,Marketing,68000");
                    writer.WriteLine("105,Amit Patel,Operations,73000");
                }

                Console.WriteLine("CSV file created and data written successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}