using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListOperations2
{
    public class ReadFromTxtFile
    {
        public string ReadFromFile()
        {
            string folderName = "EmailTemplates";
            string fileName = "emailTemplate.txt";

            string currentDirectory = Directory.GetCurrentDirectory();

            string projectBinDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            string projectDirectoryName = Directory.GetParent(projectBinDirectory).Parent.Name; // "StringAndListOperations2"
            string projectDirectory = Directory.GetParent(projectBinDirectory).Parent.FullName;

            // string test =           "C:\\Users\\jorgos.lambrinidis\\Desktop\\SMX_Apps\\ConsoleApp_Tests\\StringAndListOperations2\\StringAndListOperations2\\EmailTemplates\\emailTemplate.txt";
            // currentDirectory:       "C:\\Users\\jorgos.lambrinidis\\Desktop\\SMX_Apps\\ConsoleApp_Tests\\StringAndListOperations2\\StringAndListOperations2 \\bin\\Debug\\net7.0"
            // projectBinDirectory:    "C:\\Users\\jorgos.lambrinidis\\Desktop\\SMX_Apps\\ConsoleApp_Tests\\StringAndListOperations2\\StringAndListOperations2\\bin"
            // projectDirectory:       "C:\\Users\\jorgos.lambrinidis\\Desktop\\SMX_Apps\\ConsoleApp_Tests\\StringAndListOperations2"  


            // "C:\\Users\\jorgos.lambrinidis\\Desktop\\SMX_Apps\\ConsoleApp_Tests\\StringAndListOperations2" + "\\StringAndListOperations2" + "\\EmailTemplates" + "\\emailTemplate.txt"
            // projectDirectory + projectDirectoryName + folderName + fileName

            string text = "";

            // *** relative path ***
            // example: StringAndListOperations2\\EmailTemplates\\a\\b

            string filePath = Path.Combine(projectDirectory, projectDirectoryName, folderName, fileName);

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File cannot be read");
                Console.WriteLine(ex.Message);
            }

            return text;
        }
    }
}
