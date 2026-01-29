using System;

namespace CSharp_IO_Stream.IO_CSV.FindDuplicateRecord
{
    public class DuplicateRecord
    {
        public static void FindDuplicateRecords(string filePath)
        {
            try
            {
                var seenIDs = new HashSet<string>();
                var duplicateRecords = new List<string>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;
                    int rowNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        rowNumber++;

                        if (isHeader) // Skip header row
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(',');

                        if (data.Length < 1)
                            continue;

                        string id = data[0].Trim();

                        if (!seenIDs.Add(id))  // Add returns false if already exists
                        {
                            duplicateRecords.Add($"Row {rowNumber}: {line}");
                        }
                    }
                }

                // Print duplicates
                if (duplicateRecords.Count == 0)
                {
                    Console.WriteLine("No duplicate IDs found.");
                }
                else
                {
                    Console.WriteLine("Duplicate Records Found:\n");
                    foreach (var record in duplicateRecords)
                    {
                        Console.WriteLine(record);
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