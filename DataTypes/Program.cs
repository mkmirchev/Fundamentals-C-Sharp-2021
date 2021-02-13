using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string data = Console.ReadLine();
            if (input == "int")
            {
                DataIsInt(data);
            }
            else if (input == "real")
            {
                DataIsReal(data);
            }
            else if (input == "string")
            {
                DataIsString(data);
            }
        }

        static void DataIsInt(string a)
        {
            int value = int.Parse(a) * 2;
            Console.WriteLine(value);
        }
        static void DataIsReal(string a)
        {
            double value = double.Parse(a) * 1.5;
            Console.WriteLine($"{value:F2}");
        }
        static void DataIsString(string a)
        {
            Console.WriteLine("$"+a+"$");
        }
    }
}
