// ------------------------------------------------------------
// Program: Check whether a string is a Palindrome
// Description: A palindrome reads the same forward and backward
// Example: madam, level
// ------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // Input string
        string input = "madam";
        string reversed = "";

        // Reverse the string using loop
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        // Compare original and reversed string (case-insensitive)
        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Result: Palindrome");
        }
        else
        {
            Console.WriteLine("Result: Not a Palindrome");
        }
    }
}
