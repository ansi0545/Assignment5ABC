using System.Text.RegularExpressions;

namespace Assignment5ABC.Helpers
{
    public static class Validator
    {
        public static void ValidateNotEmpty(string value, string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(errorMessage);
            }
        }

        public static void ValidateEmailFormat(string email)
        {
            var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!emailRegex.IsMatch(email))
            {
                throw new ArgumentException("Invalid email format.");
            }
        }
    }
}