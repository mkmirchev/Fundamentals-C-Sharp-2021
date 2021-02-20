using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> stdList = new List<Students>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "end")
                {
                    break;
                }
                if ( IsStudentExisting(stdList, input[0], input[1])== true)
                {
                    GetStudent(stdList, input[0], input[1]).age = int.Parse(input[2]);
                    GetStudent(stdList, input[0], input[1]).town = input[3];
                }
                else
                {
                    Students std = new Students();
                    std.firstName = input[0];
                    std.secondName = input[1];
                    std.age = int.Parse(input[2]);
                    std.town = input[3];
                    stdList.Add(std);
                }

            }
            string filterCity = Console.ReadLine();
            List<Students> cityFiltered = stdList.Where(s => s.town == filterCity).ToList();
            foreach (var student in cityFiltered)
            {
                Console.WriteLine($"{student.firstName} {student.secondName} is {student.age} years old.");
            }
        }

        public static bool IsStudentExisting(List<Students> lst, string firstName, string secondName)
        {
            bool exist = false;
            foreach (var student in lst)
            {
                if (student.firstName == firstName && student.secondName == secondName)
                {
                    exist = true;
                }
            }
            return exist;
        }

        static Students GetStudent(List<Students> lst, string firstName, string secondName)
        {
            Students std = new Students();
            foreach (var student in lst)
            {
                if (student.firstName == firstName && student.secondName == secondName)
                {
                    std = student;
                }
            }
            return std;

        }
    }
    class Students
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int age { get; set; }
        public string town { get; set; }
    }
}
