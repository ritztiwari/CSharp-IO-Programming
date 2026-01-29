using System;

namespace CSharp_IO_Stream.IO_Stream.UserDataSave
{
    public class ExecuteUserSave
    {
        public static void Execute()
        {
            // Ask user for details
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = Console.ReadLine();

            // File path (saved in project/bin folder)
            string filePath = "user_info.txt";

            UserInfoSaver.Info(name, age, language, @"F:\CSharp-IO-Stream\IO-Stream\UserDataSave\user_info.txt");
        }
    }
}