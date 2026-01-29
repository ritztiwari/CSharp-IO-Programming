// 📌 Problem Statement: Write a C# program that reads the contents of a
// text file and writes it into a new file. If the source file does not exist,
// display an appropriate message.

using System;
using System.Text;
using System.IO;
using System.Linq.Expressions;

namespace CSharp_IO_Stream.IO_Stream.CopyContentToAnotherFile
{
    public class CopyContent
    {
        public static void CopyContentByIO()
        {
            try
            {
                using (FileStream fsRead = new FileStream(@"F:\CSharp-IO-Stream\IO-Stream\CopyContentToAnotherFile\a.txt",

    FileMode.Open, FileAccess.Read))

                using (FileStream fsWrite = new FileStream(@"F:\CSharp-IO-Stream\IO-Stream\CopyContentToAnotherFile\b.txt",

        FileMode.Create, FileAccess.Write))

                {
                    int byteData;
                    while ((byteData = fsRead.ReadByte()) != -1)

                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                    Console.WriteLine("File copied successfully.");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }

}