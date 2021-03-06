using System;
using System.Linq;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int readings = int.Parse(Console.ReadLine());
            for (int i = 0; i < readings; i++)
            {               
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double> { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var std in students.OrderByDescending(z=>z.Value.Average()))
            {
                if (std.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{std.Key} -> {std.Value.Average():F2}");
                }                
            }
        }
    }
}
