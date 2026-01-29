using System;

namespace CSharp_IO_Stream.IO_Stream.FindErrorWordInFile
{
    public class ErrorWord
    {
        public static void Find()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"F:\CSharp-IO-Stream\IO-Stream\FindErrorWordInFile\file.txt"))
                {
                    string line;
                    int lineNumber = 0;
                    bool found = false;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;

                        // Case-insensitive search
                        if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine($"Line {lineNumber}: {line}");
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("No lines containing the word 'error' were found.");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}