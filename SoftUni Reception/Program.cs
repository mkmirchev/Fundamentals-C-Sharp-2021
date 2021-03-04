using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading inputs
            int personOne = int.Parse(Console.ReadLine());
            int personTwo = int.Parse(Console.ReadLine());
            int personThree = int.Parse(Console.ReadLine());
            int questions = int.Parse(Console.ReadLine());

            //processing data
            int count= 1;
            int hours = 0;
            int questionsPerHour = (personOne + personTwo + personThree);
            while (true)

            {   if (questions <= 0)
                {
                    break;
                }
                if (count%4==0)
                {
                    hours++;
                }
                else
                {
                    questions -= questionsPerHour;
                    hours++;
                }
                count++;
            }
            //output
            Console.WriteLine("Time needed: {0}h.",hours);
            
        }
    }
}
