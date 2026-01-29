// 📌 Problem Statement: Write a program that asks the user for their
// name, age, and favorite programming language, then saves this
// information into a file.

using System;

namespace CSharp_IO_Stream.IO_Stream.UserDataSave
{
    internal class UserInfoSaver
    {
        internal static void Info(string name,string age,string language,string filePath)
        {
            try
            {
                // Create content to write
                string content = $"Name: {name}\nAge: {age}\nFavorite Language: {language}";

                // Write to file
                File.WriteAllText(filePath, content);

                Console.WriteLine("\nInformation saved successfully to " + Path.GetFullPath(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
    }
}