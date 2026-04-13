using System;

namespace CybersecurityBot
{
    public class User
    {
        public string Name { get; private set; }

        // Default constructor - prompts user to type their name
        public User()
        {
            Name = PromptForName();
        }

        // Overload constructor - used for initialisation without prompting
        public User(string name)
        {
            Name = name;
        }

        private string PromptForName()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n  Enter your name: ");
            Console.ResetColor();

            string input = Console.ReadLine() ?? string.Empty;

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  [!] Name cannot be empty. Please try again.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  Enter your name: ");
                Console.ResetColor();
                input = Console.ReadLine() ?? string.Empty;
            }

            return input.Trim();
        }
    }
}