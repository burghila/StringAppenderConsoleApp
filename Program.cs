using System;

class Program
{
    static void Main()
    {
        // Part 1: Define an array of strings that will be used to store different phrases
        string[] phrases = { "Hello, ", "How are you, ", "Welcome, " };

        // Prompting the user for input and storing that input in a variable
        Console.WriteLine("Please enter some text:");
        string userInput = Console.ReadLine();

        // Part 2: Iterate through the array using a loop
        for (int i = 0; i < phrases.Length; i++)
        {
            // For each element in the array, append the user's text to the end of the string
            phrases[i] += userInput; // This modifies the array in place, no output is shown yet
        }

        // Part 3: Loop through the array again to display each concatenated string
        for (int i = 0; i < phrases.Length; i++)
        {
            // Print each element of the array to the console, showing the updated strings
            Console.WriteLine(phrases[i]);
        }
    }
}