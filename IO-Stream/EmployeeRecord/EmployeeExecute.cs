// 📌 Problem Statement: Design a C# program that allows a user to store
// a list of employees in a file using Object Serialization and later retrieve
// the data from the file.

using System;
using System.Text.Json;

namespace CSharp_IO_Stream.IO_Stream.EmployeeRecord
{
    internal class EmployeeExecute
    {

        public static Employee AddEmployee()
        {
            Employee employee = new Employee();

            System.Console.WriteLine("enter the id");
            employee.Id = Convert.ToInt32(Console.ReadLine() ?? "");

            System.Console.WriteLine("enter the employee name");
            employee.Name = Console.ReadLine() ?? "";

            System.Console.WriteLine("enter the department");
            employee.Department = Console.ReadLine() ?? "";

            System.Console.WriteLine("enter the employee salary");
            employee.Salary = Convert.ToDouble(Console.ReadLine() ?? "");

            return employee;
        }

        public static void SaveToFile(List<Employee> employees,string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("Employees saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }
        }

        public static List<Employee> LoadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No file found.");
                    return new List<Employee>();
                }

                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Employee>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading file: " + ex.Message);
                return new List<Employee>();
            }
        }

        public static void DisplayEmployeeDetails(List<Employee> employees)
        {
            foreach (var items in employees)
            {
                System.Console.WriteLine("\n--- Employee List ---");
                System.Console.WriteLine($"id:{items.Id}\nname:{items.Name}\ndept:{items.Department}\nsalary:{items.Salary}");
            }
        }
    }
}