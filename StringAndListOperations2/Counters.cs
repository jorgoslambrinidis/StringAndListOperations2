using StringAndListOperations2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListOperations2
{
    public class Counters : ICounters
    {
        public int WordCount(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = words.Length;

            return count;
        }

        public int LetterCount(string text)
        {
            int totalLetterCount = 0;

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                int letterCount = word.Length;
                totalLetterCount += letterCount;  //totalLetterCount = totalLetterCount + letterCount;
            }

            return totalLetterCount;
        }
        public int SpacesCount(string text)
        {
            int spaceCount = 0;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            return spaceCount;
        }

        public int FullstopCount(string text)
        {
            int fullstopCount = 0;

            foreach (char c in text)
            {
                if (c == '.')
                {
                    fullstopCount++;
                }
            }

            return fullstopCount;
        }

        public int QuestionMarkCount(string text)
        {
            int questionMarkCount = 0;

            foreach (char c in text)
            {
                if (c == '?')
                {
                    questionMarkCount++;
                }
            }

            return questionMarkCount;
        }

        public int LineCount(string text)
        {
            string[] lines = text.Split(new [] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            int lineCount = lines.Length;

            return lineCount;
        }

    }
}
