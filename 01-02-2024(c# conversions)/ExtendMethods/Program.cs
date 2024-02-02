using System;

public static class Extensions
{
    // Extension method for the string type
    public static string Reverse(this string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

class Program
{
    static void Main()
    {
        // Using the extension method on a string
        string original = "Hello, World!";
        string revrse = original.Reverse();

        Console.WriteLine("Original String: " + original);
        Console.WriteLine("Reversed String: " + revrse);
    }
}
