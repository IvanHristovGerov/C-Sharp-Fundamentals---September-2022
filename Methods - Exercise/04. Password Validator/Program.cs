using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLenthValid = IsPasswordValid(password);
            bool isPasswordAplhaNumeric = IsPasswordAplhaNumeric(password);
            bool hasPassTwoDigits = IsPasswordContainingAtLeastTwoDigits(password);

            if (!isLenthValid)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (!isPasswordAplhaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasPassTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLenthValid && isPasswordAplhaNumeric && hasPassTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordValid(string password) //булев масив, защото проверяваме ДАЛИ паролата е валидна.
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPasswordAplhaNumeric(string password) //AplhaNum...= само букви и цифри
        {
            foreach (char ch in password) //ch -> за всеки символ в паролата
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCnt = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCnt++;
                }
            }
            return digitsCnt >= 2;
        }
    }
}
