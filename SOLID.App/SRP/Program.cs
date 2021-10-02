using System;
using SOLID.App.Providers;
using SOLID.App.Models;
using SOLID.App.Validators;

namespace SOLID.App
{
    class Program
    {
        static void Disable(string[] args)
        {
            OutputMessageProvider.ShowWelcomeMessage();

            OutputMessageProvider.ShowMessageForFirstNameInput();

            UserInformation.FirstName = Console.ReadLine();

            OutputMessageProvider.ShowMessageForLastNameInput();

            UserInformation.LastName = Console.ReadLine();

            OutputMessageProvider.ShowMessageForAgeInput();

            UserInformation.Age = Console.ReadLine();

            var isValidAge = AgeValidator.IsValidAge(UserInformation.Age);

            if (isValidAge)
                OutputMessageProvider.ShowMessageForValidUser(UserInformation.GetFullName());
            else
                OutputMessageProvider.ShowMessageForInvalidUser(UserInformation.GetFullName());

        }
    }
}
