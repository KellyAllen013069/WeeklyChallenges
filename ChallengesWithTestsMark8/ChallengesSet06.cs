using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;

            var comparer = ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;

            return words.Contains(word, comparer);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;

            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;

            var distinctChars = str.Where(c => str.IndexOf(c) == str.LastIndexOf(c)).ToArray();

            if (distinctChars.Length == 0) return -1;

            return str.LastIndexOf(distinctChars[^1]);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            var prev = numbers[0];
            var count = 1;
            var max = 1;
            
            for (var i = 1; i < numbers.Length;i++)
            {
                if (numbers[i] == prev) count++;
                else
                {
                    if (count > max) max = count;
                    prev = numbers[i];
                    count = 1;
                }
            }

            if (count > max) max = count;

            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List<double>();
            if (elements == null || elements.Count == 0 || n <= 0) return result.ToArray();
            for (var i = n-1; i < elements.Count; i+=n)
            {
                result.Add(elements[i]);
            }
            
            return result.ToArray();
        }
    }
}
