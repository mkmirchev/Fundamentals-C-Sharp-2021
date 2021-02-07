using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(Grades(input));
        }
        static string Grades(double a)
        {
            string output = string.Empty;
            if (a>=2 && a<3)
            {
                output = "Fail";
            }
            else if (a>=3 && a <=3.49)
            {
                output = "Poor";
            }
            else if (a >= 3.5 && a <= 4.49)
            {
                output = "Good";
            }
            else if (a >= 4.5 && a <= 5.49)
            {
                output = "Very good";
            }
            else if (a >= 5.5 && a <= 6)
            {
                output = "Excellent";
            }
            return output;
        }
    }
}
