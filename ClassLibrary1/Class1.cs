using System;
using System.Linq;

namespace ClassLibrary1
{
    public static class Class1
    {
        public static bool Validatepassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length < 8 || password.Length > 20)
                return false;

            if (!password.Any(char.IsDigit))
             
            return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            if (!password.Any(char.IsSymbol) && !password.Any(char.IsPunctuation))
                return false;

            return true;
                

        }
    }
}
