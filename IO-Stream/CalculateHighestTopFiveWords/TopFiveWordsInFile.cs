// 📌 Problem Statement: Write a C# program that counts the number of
// words in a given text file and displays the top 5 most frequently
// occurring words.
// Requirements: Use StreamReader to read the file. Use a
// Dictionary<string, int> to count word occurrences. Sort the words based
// on frequency and display the top 5.

using System;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_Stream.CalculateHighestTopFiveWords
{
    public class TopFiveWordsInFile
    {
        public static void FindTopWords()
        {
            //dictionary that will store the words and its frequency.
            Dictionary<string,int> wordCount = new Dictionary<string, int>();

            //we will read the file using streamreader.
            using(StreamReader reader = new StreamReader(@"F:\CSharp-IO-Stream\IO-Stream\CalculateHighestTopFiveWords\file.txt"))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                    //convert the capital words to small to remove redundency.
                    line = line.ToLower();

                    //creating an array of line  by splitting the line by whitespaces.
                    string[] arr = Regex.Split(line,@"\s+");
                    
                    foreach (var item in arr)
                    {
                        if (wordCount.ContainsKey(item))
                        {
                            wordCount[item]+=1;
                        }
                        else
                        {
                            wordCount[item] = 1;
                        }
                    }
                }

                //by using LINQ we will find the top 5 words in the dictionary.
                var topFiveWords = wordCount.OrderByDescending(pair => pair.Value).Take(5).ToList();

                System.Console.WriteLine("top 5 words are in the file");

                foreach (var item in topFiveWords)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}