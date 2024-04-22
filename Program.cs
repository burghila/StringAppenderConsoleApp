using System;

class Program
{
    static void Main()
    {
        // Define an array of strings
        string[] phrases = { "Hello, ", "How are you, ", "Welcome, " };

        // Ask for user input
        Console.WriteLine("Please enter some text:");
        string userInput = Console.ReadLine();

        // Append user input to each string in the array using a loop with '<' operator
        for (int i = 0; i < phrases.Length; i++)
        {
            phrases[i] += userInput;
        }

        // Print each string in the array using a loop with '<' operator
        for (int i = 0; i < phrases.Length; i++)
        {
            Console.WriteLine(phrases[i] + " (added text with '<' loop)");
        }

        // Prompt for continuation
        Console.WriteLine("Press any key to continue to the '<=' loop...");
        Console.ReadKey();

        // Print each string in the array using a loop with '<=' operator
        for (int i = 0; i <= phrases.Length - 1; i++)
        {
            Console.WriteLine(phrases[i] + " (added text with '<=' loop)");
        }
    }
}
