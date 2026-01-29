using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using CSharp_IO_Stream.IO_Stream.CopyContentToAnotherFile;
using CSharp_IO_Stream.IO_Stream.CalculateHighestTopFiveWords;
using CSharp_IO_Stream.IO_Stream.EmployeeRecord;
using CSharp_IO_Stream.IO_Stream.WriteStudentDataInBinary;
using CSharp_IO_Stream.IO_Stream.UserDataSave;
using CSharp_IO_Stream.IO_Stream.ImageVerify;
using CSharp_IO_Stream.IO_Stream.FindErrorWordInFile;


namespace CSharp_IO_Stream.IO_Stream
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // CopyContent.CopyContentByIO();

            // TopFiveWordsInFile.FindTopWords();

            // ExecuteReadWrite.Execute();

            // UpperCaseToLowerCase.ToLowerCase();

            // ExecuteUserSave.Execute();

            // serialising and deserialising the employee objects.
            List<Employee> employees = new List<Employee>();
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Employee");
                Console.WriteLine("2. Save Employees to File");
                Console.WriteLine("3. Display Employee from File");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine() ?? "");

                switch (choice)
                {
                    case 1:
                        employees.Add(EmployeeExecute.AddEmployee());
                        break;

                    case 2:
                        EmployeeExecute.SaveToFile(employees,@"F:\CSharp-IO-Stream\IO-Stream\EmployeeRecord\employees.json");
                        break;

                    case 3:
                        employees = EmployeeExecute.LoadFromFile(@"F:\CSharp-IO-Stream\IO-Stream\EmployeeRecord\employees.json");
                        EmployeeExecute.DisplayEmployeeDetails(employees);
                        break;
                }

            } while (choice != 4);
            
            // ErrorWord.Find();

            // Image.Execute();
        }
    }
}