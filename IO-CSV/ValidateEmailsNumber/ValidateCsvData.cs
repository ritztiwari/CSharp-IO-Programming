// 8️⃣Validate CSV Data Before Processing
// ● Ensure that the "Email" column follows a valid email format using regex.
// ● Ensure that "Phone Numbers" contain exactly 10 digits.
// ● Print any invalid rows with an error message.

using System;
using System.Text.RegularExpressions;

namespace CSharp_IO_Stream.IO_CSV.ValidateEmailsNumber
{
    public class ValidateCsvData
    {

        public static bool IsValidEmail(string email)
        {
            string patternEmail = @"\b[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            return Regex.IsMatch(email, patternEmail);
        }

        public static bool IsValidPhone(string number)
        {
            string patternNumber = @"\b[0-9]{10}";
            return Regex.IsMatch(number, patternNumber);
        }
        public static void Validate(string filePath)
        {
            try
            {
                bool isHeader = true;
                int rowNumber = 0;

                // System.Console.WriteLine(true);
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        rowNumber++;

                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] arr = line.Split(",");

                        if (arr.Length < 4)
                        {
                            Console.WriteLine($"Row {rowNumber}: Invalid column count.");
                            continue;
                        }

                        string email = arr[2].Trim();
                        string phone = arr[3].Trim();

                        bool isValidEmail = IsValidEmail(email);
                        bool isValidPhone = IsValidPhone(phone);

                        if (!isValidEmail || !isValidPhone)
                        {
                            Console.WriteLine($"Row {rowNumber} Invalid Data → {line}");

                            if (!isValidEmail)
                                Console.WriteLine("❌ Invalid Email Format");

                            if (!isValidPhone)
                                Console.WriteLine("❌ Phone must be exactly 10 digits");

                            Console.WriteLine();
                        }
                    }
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
        }
    }
}