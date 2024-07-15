using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any()) return 0;
            var min = numbers.Min();
            var max = numbers.Max();
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;
            return str1Length < str2Length ? str1Length : str2Length;

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            return numbers.Where(n => n % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1) return 0;
            return number / 2;
        }
    }
}
