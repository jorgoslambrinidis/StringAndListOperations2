using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListOperations2
{
    public class WriteToTxtFile
    {
        public void WriteToFile()
        {
            string folderName1 = "EmailTemplates";
            string folderName2 = "NewFiles";
            string folderName = folderName1 + "/" + folderName2; // EmailTemplates/NewFiles

            string currentDirectory = Directory.GetCurrentDirectory();
            string projectBinDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            string projectDirectoryName = Directory.GetParent(projectBinDirectory).Parent.Name;
            string projectDirectory = Directory.GetParent(projectBinDirectory).Parent.FullName;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("******************** SAVE TEXT TO FILE ********************");
            Console.ResetColor();

            Console.WriteLine("Please enter the name of the file: ");
            string fileName = Console.ReadLine() + ".txt";
            Console.WriteLine("\n");

            Console.WriteLine("Please enter some text: ");
            string input = Console.ReadLine();

            Console.WriteLine("\n");

            string filePath = Path.Combine(projectDirectory, projectDirectoryName, folderName, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(input);
            }

            Console.BackgroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine($"Text saved as {fileName}");
            Console.WriteLine($"\n");
            Console.WriteLine($"Text saved to path: {filePath}");
        }
    }
}
