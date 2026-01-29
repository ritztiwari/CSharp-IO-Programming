using System;

namespace CSharp_IO_Stream.IO_Stream.WriteStudentDataInBinary
{
    public class ExecuteReadWrite
    {
        public static void Execute()
        {
            Console.WriteLine("1. Write Student Data");
            Console.WriteLine("2. Read Student Data");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                Read_Write_BinaryFile.WriteStudents(@"F:\CSharp-IO-Stream\IO-Stream\WriteStudentDataInBinary\Students.dat");
            else if (choice == 2)
                Read_Write_BinaryFile.ReadStudents(@"F:\CSharp-IO-Stream\IO-Stream\WriteStudentDataInBinary\Students.dat");
            else
                Console.WriteLine("Invalid choice.");
        }
    }
}