using System;
using System.Linq;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < a; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                Person prsn = new Person();
                prsn.Name = input[0];
                prsn.Age = int.Parse(input[1]);
                Family.Add(family, prsn);
            }
            Person oldest = Family.GetOldestPerson(family.FamilyDB);
            Console.WriteLine("{0} {1}",oldest.Name,oldest.Age);
        }
    }

    class Person
    { 
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            FamilyDB = new List<Person>();
        }
        public Person Person { get; set; }
        public List<Person> FamilyDB{get; set;}
        public static void Add(Family fml, Person prsn)
        {
            fml.FamilyDB.Add(prsn);
        }
        public static Person GetOldestPerson(List<Person> listMembers)
        {
            Person oldestPerson = listMembers.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }
    }
}
