namespace SOLID.App.Models
{
    public static class UserInformation
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Age { get; set; }

        public static string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static string GetAge()
        {
            return Age;
        }
    }
}
