// ------------------------------------------------------------
// Program: Find the largest number in an array
// Description: Iterates through array and finds maximum value
// ------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // Initialize array
        int[] numbers = { 10, 25, 5, 78, 30 };

        // Assume first element as maximum
        int max = numbers[0];

        // Loop through array to find largest number
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display result
        Console.WriteLine("Largest Number: " + max);
    }
}
