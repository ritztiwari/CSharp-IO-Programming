// 📌 Problem Statement: Create a program that reads a text file and
// writes its contents into another file, converting all uppercase letters to
// lowercase.

using System;
using System.Text;
using System.IO;

namespace CSharp_IO_Stream.IO_Stream
{
    internal class UpperCaseToLowerCase
    {
        internal static void ToLowerCase()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"F:\CSharp-IO-Stream\IO-Stream\CaseUpperToLower\a.txt"))
                using (StreamWriter writer = new StreamWriter(@"F:\CSharp-IO-Stream\IO-Stream\CaseUpperToLower\b.txt"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string lowerCase = line.ToLower();
                        writer.WriteLine(lowerCase);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}