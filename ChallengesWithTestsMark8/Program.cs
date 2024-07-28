using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            var c6 = new ChallengesSet06();
            var uniqueIndex = c6.IndexOfLastUniqueLetter("Programming");
            Console.WriteLine($"unique is: {uniqueIndex}");
            // Console.WriteLine("Hello, world!");
        }
    }
}
