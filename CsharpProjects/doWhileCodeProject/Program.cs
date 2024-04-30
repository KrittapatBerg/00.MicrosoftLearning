using System;

namespace doWhileCodeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateIntegerInput();
            ValidateRoleName();
        }

        static void ValidateIntegerInput()
        {
            int input;
            string inputText = "Please enter an integer value between 5 and 10";

            do
            {
                Console.WriteLine(inputText);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out input) && input >= 5 && input <= 10)
                {
                    Console.WriteLine($"Your input value ({input}) has been accepted");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid input. Please enter an integer value between 5 and 10.");
                }
            } while (true);
        }

        static void ValidateRoleName()
        {
            string question = "Enter your role name (Administrator, Manager, or User)";
            string[] validRoles = { "administrator", "manager", "user" };

            do
            {
                Console.WriteLine(question);
                string userInput = Console.ReadLine().ToLower();

                if (Array.Exists(validRoles, role => role == userInput))
                {
                    Console.WriteLine($"Your input value is accepted\nWelcome {userInput}");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid role name. Please enter a valid role name.");
                }
            } while (true);
        }
    }
}