using System;

namespace SOLID.App.Providers
{
    public static class OutputMessageProvider
    {
        public static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to Age Restriction App");
        }

        public static void ShowMessageForFirstNameInput()
        {
            Console.WriteLine("Please provide your first name");
        }

        public static void ShowMessageForLastNameInput()
        {
            Console.WriteLine("Please provide your last name");
        }
        public static void ShowMessageForAgeInput()
        {
            Console.WriteLine("Please provide your age");
        }

        public static void ShowMessageForInvalidUser(string fullName)
        {
            Console.WriteLine($"Sorry dear {fullName}, " +
                $"we are afraid you cannot use our app (only persons older than 18 years of age are allowed)");
        }

        public static void ShowMessageForValidUser(string fullName)
        {
            Console.WriteLine($"You are welcome {fullName} to use our app");
        }
    }
}
