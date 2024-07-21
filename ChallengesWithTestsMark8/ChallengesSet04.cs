using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
       
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (var n in numbers)
            {
                result = (n % 2 == 0) ? result + n : result - n;
            }

            return result;
        }
        
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1, str2, str3, str4 }.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sides = new[] { sideLength1, sideLength2, sideLength3 }
                .OrderBy(s => s)
                .ToArray();

            return sides[0] + sides[1] > sides[2];

        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(obj => obj == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            var evens = numbers.Where(n => n % 2 == 0).ToList();
            return evens.Any() ? evens.Average() : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException(nameof(number), "Number must be non-negative.");
            return Enumerable.Range(1, number).Aggregate(1, (acc, val) => acc * val);
        }
    }
}
