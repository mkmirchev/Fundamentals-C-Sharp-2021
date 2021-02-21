using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            List<Student> stdList = new List<Student>();
            for (int i = 0; i < inputs; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                Student std = new Student
                {
                    FirstName = input[0], 
                    SecondName = input[1], 
                    Grade = double.Parse(input[2])
                };
                stdList.Add(std);
            }
            stdList = stdList.OrderByDescending(x => x.Grade).ToList();
            foreach (Student student in stdList)
            {
                Console.WriteLine(student);
            }
        }
    }
    public class Student
    { 
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:F2}";
        }
    }
}
