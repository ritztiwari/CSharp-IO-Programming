// 📌 Problem Statement: Write a C# program that stores student details
// (roll number, name, GPA) in a binary file and retrieves it later.
// Requirements: Use BinaryWriter to write primitive data. Use
// BinaryReader to read data. Ensure proper closing of resources.

using System;

namespace CSharp_IO_Stream.IO_Stream.WriteStudentDataInBinary
{
    public class Read_Write_BinaryFile
    {
        public static void WriteStudents(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                Console.Write("How many students? ");
                int count = int.Parse(Console.ReadLine());

                writer.Write(count); // Store number of students first

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nStudent {i + 1}");

                    Console.Write("Roll Number: ");
                    int roll = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("GPA: ");
                    double gpa = double.Parse(Console.ReadLine());

                    writer.Write(roll);
                    writer.Write(name);
                    writer.Write(gpa);
                }

                Console.WriteLine("\n✅ Data written successfully!");
            } // Automatically closes writer and file stream
        }

        // Reading student data from binary file
        public static void ReadStudents(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No data file found.");
                return;
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int count = reader.ReadInt32(); // Read number of students

                Console.WriteLine($"\n📚 Total Students: {count}\n");

                for (int i = 0; i < count; i++)
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine($"Student {i + 1}");
                    Console.WriteLine($"Roll Number: {roll}");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"GPA: {gpa:F2}");
                    Console.WriteLine();
                }
            } // Automatically closes reader and file stream
        }
    }
}
