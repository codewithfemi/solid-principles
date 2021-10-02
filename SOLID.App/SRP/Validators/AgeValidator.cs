namespace SOLID.App.Validators
{
    public static class AgeValidator
    {
        public static bool IsValidAge(string age)
        {
            var isAgeInteger = int.TryParse(age, out int ageValue);
            if (isAgeInteger && ageValue > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
