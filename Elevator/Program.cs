using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCourses = people / capacity;
            int additionalCourse = 0;
            if (people - fullCourses * capacity > 0)
            {
                additionalCourse = 1;
            }
            int totalCourses = fullCourses + additionalCourse;
            Console.WriteLine(totalCourses);
        }
    }
}
