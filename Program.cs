using System;

class Program
{
    static void Main()
    {
        string[] phrases = { "Hello, ", "How are you, ", "Welcome, " };

        // Corrected the infinite loop by adding a condition to exit
        while (true) // Start of the infinite loop
        {
            Console.WriteLine("Please enter some text:");
            string userInput = Console.ReadLine();

            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] += userInput;
            }

            // Loop that prints each string in the array
            for (int i = 0; i < phrases.Length; i++)
            {
                Console.WriteLine(phrases[i]);
            }

            // Asking the user if they want to continue or exit the loop
            Console.WriteLine("Would you like to add more text? (yes/no)");
            string answer = Console.ReadLine();

            // Conditional check to break the infinite loop
            if (answer.ToLower() != "yes")
            {
                break; // Break statement to exit the loop
            }
            // The loop will continue if the user inputs "yes", otherwise it will exit
        }
    }
}
