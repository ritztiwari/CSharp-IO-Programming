// 9️⃣Convert CSV Data into Java Objects
// ● Read a CSV file and convert each row into a Student Java object.
// ● Store the objects in a List<Student> and print them.

using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace CSharp_IO_Stream.IO_CSV.StoreCsvToLists
{
    public class StoreCsvToList
    {
        public static void Store(string filePath)
        {
            try
            {
                bool isHeader = true;
                var students = new List<Student>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] arr = line.Split(",");

                        students.Add(new Student{ id = arr[0], name = arr[1], age = arr[2], marks = arr[3] });
                    }
                }

                foreach (var item in students)
                {
                    System.Console.WriteLine("---student record---");
                    System.Console.WriteLine($"id is: {item.id}\nname is: {item.name}\nage is; {item.age}\nmarks is: {item.marks}\n");
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