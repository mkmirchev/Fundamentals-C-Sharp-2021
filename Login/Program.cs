using System;
using System.Text;
namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputData = "";
            int counter = 0;
            var password = new StringBuilder(username.Length);

            for (int i = (username.Length -1); i >= 0; i--)
            {
                password.Append(username[i]);
            }
            while (true)
            {               
                if (counter == 3)
                {
                    Console.WriteLine("User "+username+" blocked!");
                    break;
                }
                inputData = Console.ReadLine();
                if (password.ToString() == inputData)
                {
                    Console.WriteLine("User " + username + " logged in.");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter++;             
            }
        }
    }
}
