using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordConditionCheck(password);
        }

        static void PasswordConditionCheck(string pass)
        {
            bool isValid = true;
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            int count = 0;
            foreach (var ch in pass)
            {
                if (48 > ch && ch < 57 && 65 > ch && ch < 90 && 97 > ch && ch < 122)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
                if (ch >= 48 && ch <= 57)
                {
                    count++;
                }

            }
            if (count < 2)
            {
                    Console.WriteLine("Password must have at least 2 digits");
                    isValid = false;
            }
            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
