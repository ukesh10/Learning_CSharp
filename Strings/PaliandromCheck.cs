using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCSharp.Strings
{
    public class PaliandromCheck
    {
        public static bool IsPaliandrom(string str)
        {
            if (string.IsNullOrEmpty(str)) throw new Exception("string cannot be empty or white space.");
            int left = 0, right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        public static void Run()
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(IsPaliandrom(str));
        }
    }
}