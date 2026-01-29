using System;

namespace CSharp_IO_Stream.IO_Stream.ImageVerify
{
    public class Image
    {
        public static void Execute()
        {
            try
            {
                // Step 1: Read image into byte array
                byte[] imageBytes;
                using (FileStream fs = new FileStream(@"F:\CSharp-IO-Stream\IO-Stream\ImageVerify\image.jpg", FileMode.Open, FileAccess.Read))
                {
                    imageBytes = new byte[fs.Length];
                    fs.Read(imageBytes, 0, imageBytes.Length);
                }

                Console.WriteLine($"Original image size: {imageBytes.Length} bytes");

                // Step 2: Use MemoryStream to hold byte array
                byte[] copiedBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    copiedBytes = ms.ToArray();
                }

                // Step 3: Write byte array back to new image file
                using (FileStream fs = new FileStream(@"F:\CSharp-IO-Stream\IO-Stream\ImageVerify\newImage.jpg", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(copiedBytes, 0, copiedBytes.Length);
                }

                Console.WriteLine("Image successfully copied using MemoryStream.");

                // Step 4: Verify both files are identical
                bool identical = File.ReadAllBytes(@"F:\CSharp-IO-Stream\IO-Stream\ImageVerify\Image.jpg")
                                    .SequenceEqual(File.ReadAllBytes(@"F:\CSharp-IO-Stream\IO-Stream\ImageVerify\newImage.jpg"));

                Console.WriteLine(identical
                    ? "Verification Success: Files are identical ✅"
                    : "Verification Failed: Files differ ❌");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
