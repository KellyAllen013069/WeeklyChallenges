using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var i = startNumber + 1;
            while (true)
            {
                if (i % n == 0) return i;
                i++;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var b in businesses)
            {
                if (b.TotalRevenue == 0d) b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i+1]) return false;
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            var sum = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0) sum += numbers[i + 1];
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";

            var filteredWords = words
                .Where(w => !string.IsNullOrWhiteSpace(w)).ToArray()
                .Select(w => w.Trim())
                .ToArray();
            
            if (filteredWords.Length == 0) return "";
            
            return string.Join(" ", filteredWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var result = new List<double>();
            
            if (elements == null || elements.Count < 4) return result.ToArray();
            
            for (var i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0) return false;
            
            HashSet<int> seenNumbers = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var result = targetNumber - nums[i];
                if (seenNumbers.Contains(result)) return true;

                seenNumbers.Add(nums[i]);
            }

            return false;

        }
    }
}
