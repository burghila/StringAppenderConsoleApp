using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

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

        // Part 5: List of strings with duplicates
        List<string> phrasesWithDuplicates = new List<string> { "apple", "banana", "cherry", "apple", "date", "cherry" };

        // Ask user to input text to search for in the list with duplicates
        Console.WriteLine("Please enter text to search for in the list with duplicates:");
        searchText = Console.ReadLine();
        found = false;  // Reset found flag for new search

        // Iterate through the list and find all occurrences of the search text
        for (int i = 0; i < phrasesWithDuplicates.Count; i++)
        {
            if (phrasesWithDuplicates[i].Contains(searchText))
            {
                Console.WriteLine($"Matching text found at index: {i}");
                found = true;
            }
        }

        // Check if the search text was not found at all
        if (!found)
        {
            Console.WriteLine("Your input is not on the list.");
        }
    }
}
