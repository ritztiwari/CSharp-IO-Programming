// 7️⃣Sort CSV Records by a Column

// ● Read a CSV file and sort the records by Salary in descending order.
// ● Print the top 5 highest-paid employees.

using System;
using System.IO;
using System.Net;

namespace CSharp_IO_Stream.IO_CSV.SortRowsBySalaries
{
    public class SortRowsBySalary
    {
        public static void SortSalary(string filePath)
        {
            try
            {
                var employee = new List<Employee>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    bool isHeader = true;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(",");

                        if (data.Length < 4)
                        {
                            continue;
                        }

                        if (double.TryParse(data[3], out double salary))
                        {
                            employee.Add(new Employee
                            {
                                Id = data[0],
                                Name = data[1],
                                Department = data[2],
                                Salary = salary
                            });
                        }
                    }
                }

                var topEmployees = employee.OrderByDescending(e => e.Salary).Take(5).ToList();

                foreach (var item in topEmployees)
                {
                    System.Console.Write($"id is: {item.Id}\tname is: {item.Name}\tdepartment is: {item.Department}\tsalary is: {item.Salary}\n");
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