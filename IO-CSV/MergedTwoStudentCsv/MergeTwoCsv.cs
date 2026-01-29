// 🔟 Merge Two CSV Files
// ● You have two CSV files:
// ○ students1.csv (contains ID, Name, Age)
// ○ students2.csv (contains ID, Marks, Grade)
// ● Merge both files based on ID and create a new file containing all details.

using System;
using System.Buffers;
using System.Data.Common;
using System.Formats.Asn1;
using System.Formats.Tar;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CSharp_IO_Stream.IO_CSV.MergeTwoStudentCsv
{
    public class MergeTwoCsv
    {
        public static void Merge(string filePath1, string filePath2)
        {
            try
            {
                bool isHeader = true;

                using (StreamReader reader1 = new StreamReader(filePath1))
                using (StreamReader reader2 = new StreamReader(filePath2))
                using (StreamWriter writer = new StreamWriter(@"F:\CSharp-IO-Stream\IO-CSV\MergedStudent.csv"))
                {
                    string line1;
                    string line2;

                    while ((line1 = reader1.ReadLine()) != null && (line2 = reader2.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            writer.WriteLine("Id,Name,Age,Marks,Grade");
                            isHeader = false;
                            continue;
                        }

                        string[] arr1 = line1.Split(",");
                        string[] arr2 = line2.Split(",");

                        if(arr1[0] == arr2[0])
                        {
                            writer.WriteLine($"{arr1[0]},{arr1[1]},{arr1[2]},{arr2[1]},{arr2[2]}");
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
            finally
            {
                System.Console.WriteLine("Program ended");
            }
        }
    }
}