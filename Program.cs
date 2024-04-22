using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Part 1: One-dimensional array of strings
        string[] phrases = { "Hello, ", "How are you, ", "Welcome, " };

        // Ask user to input some text
        Console.WriteLine("Please enter some text:");
        string userInput = Console.ReadLine();

        // Loop that iterates through each string in the array and appends the user's input
        for (int i = 0; i < phrases.Length; i++)
        {
            phrases[i] += userInput;
        }

        // Print each updated string in the array
        for (int i = 0; i < phrases.Length; i++)
        {
            Console.WriteLine(phrases[i]);
        }

        // Part 2: Infinite loop management (adjusted in Part 3 below)

        // Part 3: Loop with '<' and '<=' comparisons
        Console.WriteLine("Press any key to continue to the '<' loop...");
        Console.ReadKey();

        // Using '<' operator to print strings
        for (int i = 0; i < phrases.Length; i++)
        {
            Console.WriteLine(phrases[i] + " (added text with '<' loop)");
        }

        Console.WriteLine("Press any key to continue to the '<=' loop...");
        Console.ReadKey();

        // Using '<=' operator to print strings
        for (int i = 0; i <= phrases.Length - 1; i++)
        {
            Console.WriteLine(phrases[i] + " (added text with '<=' loop)");
        }

        // Part 4: List of unique strings and search functionality
        List<string> uniqueStrings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

        Console.WriteLine("Please enter text to search for in the list:");
        string searchText = Console.ReadLine();
        bool matchFound = false;

        // Loop to find the search text in the list
        for (int i = 0; i < uniqueStrings.Count; i++)
        {
            if (uniqueStrings[i].Contains(searchText))
            {
                Console.WriteLine($"Matching text found at index: {i}");
                matchFound = true;
                break; // Exit loop once a match is found
            }
        }

        // Inform user if no match is found
        if (!matchFound)
        {
            Console.WriteLine("Your input is not on the list.");
        }
    }
}
