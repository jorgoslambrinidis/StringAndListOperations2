using StringAndListOperations2;
using StringAndListOperations2.Interfaces;

GenerateEmailTemplates generateMarketingEmail = new GenerateEmailTemplates();
ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
//Counters counters = new Counters();
ICounters counters = new Counters();

//generateMarketingEmail.GenerateMarketingEmailTemplate();

//string string1 = "Hello";
//string string2 = "hello";

// .Equals
// opcija 1
//bool result = string1 == string2;

// opcija 2 
//bool result = string1.Equals(string2, StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(result);

//.Insert() 
//string string1 = "Hello World";
//string substring = "Nekoj ";
//int position = 6;

//string result = string1.Insert(position, substring);

//Console.WriteLine(result);

// .Compare()"

//string firstString = "Hello";
//string secondString = "World";

//int result = String.Compare(firstString, secondString);

//if (result < 0)
//{
//    Console.WriteLine(firstString + " comes before " +  secondString);
//}
//else if (result > 0)
//{
//    Console.WriteLine(secondString + " comes before " + firstString);
//}
//else
//{
//    Console.WriteLine("The two strings are equal");
//}


// .Remove()

//string firstString = "Hello World";

//int startIndex = 6;
//int count = 5;

//string result = firstString.Remove(startIndex, count);

//Console.WriteLine(result);



// .Count()"
//string firstString = "Hello World";
//char character = 'o';

//int count = 0;

//count = firstString.Count(c => c == character);

//Console.WriteLine(count);

// .Join()

//string[] words = { "Hello", "World", "Hello1", "Hello2" };
//string separator = "-------------";

//string result = String.Join(separator, words);
//Console.WriteLine(result);


// .IndexOf()
//string firstString = "Hello World";
//char character = 'o';
//int index = firstString.IndexOf(character);
//Console.WriteLine(index);
//int lastIndex = firstString.LastIndexOf(character);
//Console.WriteLine(lastIndex);

Console.ForegroundColor = ConsoleColor.Cyan;
string emailTemplate = readFromTxtFile.ReadFromFile();
Console.WriteLine(emailTemplate);
Console.ResetColor();

Console.WriteLine("**********************************************\n");

int wordCount = counters.WordCount(emailTemplate);
int letterCount = counters.LetterCount(emailTemplate);
int lineCount = counters.LineCount(emailTemplate);
int fullstopCount = counters.FullstopCount(emailTemplate);
int spaceCount = counters.SpacesCount(emailTemplate);
int questionMarkCount = counters.QuestionMarkCount(emailTemplate);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Word counter: " + wordCount);
Console.WriteLine("**********************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Letter counter: " + letterCount);
Console.WriteLine("**********************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Line counter: " + lineCount);
Console.WriteLine("**********************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Fullstop counter: " + fullstopCount);
Console.WriteLine("**********************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Space counter: " + spaceCount);
Console.WriteLine("**********************************************");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Question mark counter: " + questionMarkCount);
Console.WriteLine("**********************************************");
Console.ResetColor();
