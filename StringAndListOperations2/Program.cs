using StringAndListOperations2;
using StringAndListOperations2.Interfaces;

GenerateEmailTemplates generateMarketingEmail = new GenerateEmailTemplates();
ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
WriteToTxtFile writeToTxtFile = new WriteToTxtFile();
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

//Console.ForegroundColor = ConsoleColor.Cyan;
//string emailTemplate = readFromTxtFile.ReadFromFile();
//Console.WriteLine(emailTemplate);
//Console.ResetColor();

//Console.WriteLine("**********************************************\n");

//int wordCount = counters.WordCount(emailTemplate);
//int letterCount = counters.LetterCount(emailTemplate);
//int lineCount = counters.LineCount(emailTemplate);
//int fullstopCount = counters.FullstopCount(emailTemplate);
//int spaceCount = counters.SpacesCount(emailTemplate);
//int questionMarkCount = counters.QuestionMarkCount(emailTemplate);

//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine("Word counter: " + wordCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.WriteLine("Letter counter: " + letterCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("Line counter: " + lineCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("Fullstop counter: " + fullstopCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("Space counter: " + spaceCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();

//Console.ForegroundColor = ConsoleColor.DarkMagenta;
//Console.WriteLine("Question mark counter: " + questionMarkCount);
//Console.WriteLine("**********************************************");
//Console.ResetColor();


// ---------------------------------------------- LIST METHODS ------------------------------------------------



// Add element to list
List<int> intList = new List<int>();
intList.Add(1);
intList.Add(2);
intList.Add(3);
intList.Add(4);
intList.Add(5);

// Add multiple elements to list
List<int> intList2 = new List<int>();
intList2.AddRange(new int[] { 1, 2, 3 });
intList.AddRange(new int[] { 1, 2, 3 });

// Remove element from a list by index
//intList.RemoveAt(5);

// Remove element from a list by value
//intList.Remove(1);

// Remove all element that match a condition by element
//intList.RemoveAll(x => x == 1);

// Get the number of elements in a list
//List<int> intList3 = new List<int> { 1, 2, 3 };
//int numberOfElements = intList3.Count;

//if (numberOfElements == 0)
//{
//    Console.WriteLine("Listata e prazna");
//}
//else if (numberOfElements > 0)
//{
//    Console.WriteLine("Listata e polna");
//}

// Get the index of an element in a list
//List<int> intList4 = new List<int> { 1, 2, 3 };
//int index = intList4.IndexOf(2);

// How to sort a list in an ascending order
//List<int> intList5 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList5.Sort();

// How to sort a list in an descending order
//List<int> intList6 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList6.Sort((a, b) => b.CompareTo(a));

//List<int> _intListTemp = new List<int>();

//foreach (var item in intList6)
//{
//    int _temp = 0;

//    if (item > _temp)
//    {
//        _temp = item;
//        _intListTemp.Add(item);
//    }
//}

//_intListTemp = intList;


// How to check if a list contains a specific element
//List<int> intList7 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<string> stringList7 = new List<string> { "John", "Doe", "Asssaa" };
//bool containsElement = intList7.Contains(3);
//bool containsElement2 = stringList7.Contains("Bla");

//int getTheIndex = intList7.IndexOf(3);


//if (containsElement2)
//{
//    int getTheIndex2 = stringList7.IndexOf("Bla");
//    string getItemFromList = stringList7[getTheIndex2];
//}

// How to clear all elements from a list
//List<int> intList8 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//intList8.Clear();

// How to create a new list that contains only the even numbers from an existing list?
//List<int> intList8 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<int> evenNumbers = intList8.FindAll(x => x % 2 == 0);

// How to concatenate two lists into a new list?
//List<int> intList9 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//List<int> intList10 = new List<int> { 11, 10, 12, 16 };
//List<int> concatenatedList = intList9.Concat(intList10).ToList();


// How to get the first element in a list?
// How to get the last element in a list?
//List<int> intList10 = new List<int> { 7, 1, 2, 9, 3, 4, 5, 6, 8 };
//int firstElement = intList10.First();
//int lastElement = intList10.Last();


Console.WriteLine("");

writeToTxtFile.WriteToFile();


