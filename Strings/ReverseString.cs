using System;

namespace LearningCSharp.Strings;
public class ReverseString
{
    public static string Reverse(string str)
    {
        if (string.IsNullOrWhiteSpace(str)) throw new Exception("Please enter valid string");

        // char[] charArray = str.ToCharArray();
        // Array.Reverse(charArray);
        // return new string(charArray);

        // or

        string reversed = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--){
            reversed += str[i];
        }
        return reversed;
    }

    public static void Run()
    {
        Console.Write("Enter a string to reverse: ");
        string? input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Reversed: " + Reverse(input));
    }
}