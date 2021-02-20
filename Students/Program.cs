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
                Students std = new Students();
                std.firstName = input[0];
                std.secondName = input[1];
                std.age = int.Parse(input[2]);
                std.town = input[3];
                stdList.Add(std);
            }
            string filterCity = Console.ReadLine();
            List<Students> cityFiltered = stdList.Where(s => s.town == filterCity).ToList();
            foreach (var student in cityFiltered)
            {
                Console.WriteLine($"{student.firstName} {student.secondName} is {student.age} years old.");
            }
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
