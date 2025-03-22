using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCSharp.Strings
{
    public class FindDuplicates
    {
        public static string FindAllDuplicates(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) throw new Exception("string should not be null or whitespace.");

            Dictionary<char, int> charCount = new();
            foreach (var ch in str.ToLower())
            {
                if (ch == ' ' || !char.IsLetter(ch)) continue;

                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else charCount[ch] = 1;
            }
            var duplicates = charCount.Where(x => x.Value > 1).Select(x => x.Key).ToList();

            return duplicates.Count == 0 ? "No Duplicates found." : string.Join(", ", duplicates);
        }
        public static void Run()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(FindAllDuplicates(input));
        }
    }
}