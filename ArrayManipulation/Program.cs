using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //gathering input array
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //array manipulation until end command
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    List<int> lst = new List<int>();
                    foreach (var item in input)
                    {
                        lst.Add(item);
                    }
                    Console.WriteLine("[" + string.Join(", ",lst) +"]");
                    break;
                }
                string[] operations = command.Split(' ').ToArray();
                if (operations[0] == "exchange")
                {
                    if (int.Parse(operations[1]) < 0 || int.Parse(operations[1]) > input.Length-1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        input = ExchangeArray(input, int.Parse(operations[1]));
                    }       
                }
                if (command == "max odd")
                {
                    GetMaxOddIndex(input);
                }
                if (command == "max even")
                {
                    GetMaxEvenIndex(input);
                }
                if (command == "min odd")
                {
                    GetMinOddIndex(input);
                }
                if (command == "min even")
                {
                    GetMinEvenIndex(input);
                }
                if (command.Contains("first") && command.Contains("odd"))
                {
                    string[] cmd = command.Split(' ').ToArray();
                    int firstN = int.Parse(cmd[1]);
                    GetFirstNOdd(input, firstN);
                }
                if (command.Contains("first") && command.Contains("even"))
                {
                    string[] cmd = command.Split(' ').ToArray();
                    int firstN = int.Parse(cmd[1]);
                    GetFirstNEven(input, firstN);
                }
                if (command.Contains("last") && command.Contains("odd"))
                {
                    string[] cmd = command.Split(' ').ToArray();
                    int firstN = int.Parse(cmd[1]);
                    GetLastNOdd(input, firstN);
                }
                if (command.Contains("last") && command.Contains("even"))
                {
                    string[] cmd = command.Split(' ').ToArray();
                    int firstN = int.Parse(cmd[1]);
                    GetLastNEven(input, firstN);
                }
            }
        }

        static int[] ExchangeArray(int[] a, int separatingIndex) // it is tested and works good
        {
            int[] newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (separatingIndex+i < a.Length-1)
                {
                    newArr[i] = a[separatingIndex + i + 1];
                }
                else
                {
                    newArr[i] = a[i-a.Length+separatingIndex+1];
                }
            }
            return newArr;
        }

        static void GetMaxOddIndex(int[] a)
        {
            int output = int.MinValue;
            int value = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= value &&
                    a[i] % 2 == 1)
                {
                    output = i;
                    value = a[i];
                }
            }
            if (output == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(output);
            }
        } // tested

        static void GetMaxEvenIndex(int[] a)
        {
            int output = int.MinValue;
            int value = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= value &&
                    a[i] % 2 == 0)
                {
                    output = i;
                    value = a[i];
                }
            }
            if (output == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(output);
            }
        }// tested
        static void GetMinOddIndex(int[] a)
        {
            int output = int.MaxValue;
            int value = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= value &&
                    a[i] % 2 == 1)
                {
                    output = i;
                    value = a[i];
                }
            }
            if (output == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(output);
            }
        }// tested

        static void GetMinEvenIndex(int[] a)
        {
            int output = int.MaxValue;
            int value = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= value &&
                    a[i] % 2 == 0)
                {
                    output = i;
                    value = a[i];
                }
            }
            if (output == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(output);
            }
        }//tested

        static void GetFirstNOdd(int[] input, int a)
        {
            if (a > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int count = 0;
                List<int> lst = new List<int>();
                int arrCount = 0;
                while (count < input.Length)
                {
                    if (input[count] % 2 == 1 && arrCount < a)
                    {
                        lst.Add(input[count]);
                        arrCount++;
                    }
                    count++;
                }
                Console.WriteLine("[" + string.Join(", ", lst) + "]");
            }
        }
        static void GetFirstNEven(int[] input, int a)
        {
            if (a > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int count = 0;
                int arrCount = 0;
                List<int> lst = new List<int>();
                while (count < input.Length)
                {
                    if (input[count] % 2 == 0 && arrCount < a)
                    {
                        lst.Add(input[count]);
                        arrCount++;
                    }
                    count++;
                }
                Console.WriteLine("["+string.Join(", ", lst) + "]");

            }
        }

        static void GetLastNOdd(int[] input, int a)
        {
            if (a > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int count = input.Length - 1;
                int arrCount = 0;
                List<int> lst = new List<int>();
                while (count >= 0)
                {
                    if (input[count] % 2 == 1 && arrCount < a)
                    {
                        lst.Add(input[count]);
                        arrCount++;
                    }
                    count--;
                }
                lst.Reverse();
                Console.WriteLine("[" + string.Join(", ", lst) + "]");
            }      
        }

        static void GetLastNEven(int[] input, int a)
        {
            if (a > input.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int count = input.Length - 1;
                List<int> lst = new List<int>();
                int arrCount = 0;
                while (count >= 0)
                {
                    if (input[count] % 2 == 0 && arrCount < a)
                    {
                        lst.Add(input[count]);
                        arrCount++;
                    }
                    count--;
                }
                Console.WriteLine("[" + string.Join(", ", lst) + "]");

            }
            
        }
    }
}
