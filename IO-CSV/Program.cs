using System;
using CSharp_IO_Stream.IO_CSV.StudentRecords;
using CSharp_IO_Stream.IO_CSV.WriteEmployeeRecords;
using CSharp_IO_Stream.IO_CSV.CountRows;
using CSharp_IO_Stream.IO_CSV.FindDuplicateRecord;
using CSharp_IO_Stream.IO_CSV.MarksGreatorThanEighty;
using CSharp_IO_Stream.IO_CSV.MergeTwoStudentCsv;
using CSharp_IO_Stream.IO_CSV.ModifySalaries;
using CSharp_IO_Stream.IO_CSV.SearchEmployees;
using CSharp_IO_Stream.IO_CSV.SortRowsBySalaries;
using CSharp_IO_Stream.IO_CSV.StoreCsvToLists;
using CSharp_IO_Stream.IO_CSV.ValidateEmailsNumber;
using CSharp_IO_Stream.IO_CSV.WriteEmployeeRecords;

namespace CSharp_IO_Stream.IO_CSV
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // StudentRecord.PrintRecord(@"F:\CSharp-IO-Stream\IO-CSV\StudentRecords\Student.csv");

            WriteEmployeeRecord.WriteRecord(@"F:\CSharp-IO-Stream\IO-CSV\WriteEmployeeRecords\Employee.csv");

            // int row = CountRow.Rows(@"F:\CSharp-IO-Stream\IO-CSV\CountRows\Employee.csv");
            // System.Console.WriteLine($"total number of rows are {row}");

            // MarksGreatorThan80.Find(@"F:\CSharp-IO-Stream\IO-CSV\MarksGreatorThanEigthy\Student.csv");

            // SearchEmployee.Find(@"F:\CSharp-IO-Stream\IO-CSV\SearchEmployees\Employee.csv","rishabh tiwari");

            // ModifySalary.ModifySalaryOfIT(@"F:\CSharp-IO-Stream\IO-CSV\ModifySalaries\Employee.csv");

            // SortRowsBySalary.SortSalary(@"F:\CSharp-IO-Stream\IO-CSV\SortRowsBySalaries\Employee.csv");

            // ValidateCsvData.Validate(@"F:\CSharp-IO-Stream\IO-CSV\ValidateEmailsNumber\Data.csv");

            // StoreCsvToList.Store(@"F:\CSharp-IO-Stream\IO-CSV\StoreCsvToLists\Student.csv");

            // MergeTwoCsv.Merge(@"F:\CSharp-IO-Stream\IO-CSV\MergedTwoStudentCsv\Student1.csv",@"F:\CSharp-IO-Stream\IO-CSV\MergedTwoStudentCsv\Student2.csv");

            // DuplicateRecord.FindDuplicateRecords(@"F:\CSharp-IO-Stream\IO-CSV\FindDuplicateRecord\Employee.csv");
        }
    }
}
