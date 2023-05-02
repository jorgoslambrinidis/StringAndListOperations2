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
        // Word Count
        public int WordCount(string text)
        {
            int count = 0;

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            count = words.Length;

            return count;
        }

        public void LetterCount() { }

        public void LineCount() { }

        public void SpacesCount() { }

        public void FullStopCount() { }

       
    }
}
