using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "End")
                {
                    break;
                }
                Person prsn = new Person();
                prsn.Name = input[0];
                prsn.ID = input[1];
                prsn.Age = int.Parse(input[2]);
                persons.Add(prsn);
            }
            List<Person> sortedList = persons.OrderBy(x => x.Age).ToList();
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person
    { 
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }

        public override string ToString()
        {
            string output = $"{Name} with ID: {ID} is {Age} years old.";
            return output;
        }
    }
}
