using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<Employee> humanResource = new List<Employee>();
            for (int i = 0; i < input; i++)
            {
                string[] currentEmployee = Console.ReadLine().Split(' ').ToArray();
                Employee newEmployee = new Employee();
                newEmployee.Name = currentEmployee[0];
                newEmployee.Salary = decimal.Parse(currentEmployee[1]);
                newEmployee.Department = currentEmployee[2];
                humanResource.Add(newEmployee);
            }
            string highestSalaryDep = GetDepartmentWithMaxSalary(humanResource);
            Console.WriteLine("Highest Average Salary: " + highestSalaryDep);
            List<Employee> sortedEmployees = humanResource.OrderByDescending(x => x.Salary).ToList();
            foreach (var item in sortedEmployees)
            {
                if (item.Department == highestSalaryDep )
                {
                    Console.WriteLine("{0} {1:F2}",item.Name, item.Salary);
                }
            }
            

            

   
        }
        public static string GetDepartmentWithMaxSalary(List<Employee> depList)
        {
            List<string> departments = new List<string>();
            foreach (var item in depList)
            {
                if (!departments.Contains(item.Department))
                {
                    departments.Add(item.Department);
                }
            }
            decimal maxSalary = 0;
            int maxCount = 0;
            int count = 0;
            foreach (var dep in departments)
            {
                decimal currentSalary = 0;
                foreach (var item in depList)
                {
                    if (item.Department == dep)
                    {
                        currentSalary += item.Salary;
                    }
                }
                if (currentSalary > maxSalary)
                {
                    maxSalary = currentSalary;
                    maxCount = count;
                }
                count++;
            }
            return departments[maxCount];
        }
    }

    class Employee
    {
        public Employee()
        {

        }
        public Employee( string name, decimal salary, string dep)
        {
            name = Name;
            salary = Salary;
            dep = Department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

    }
}
