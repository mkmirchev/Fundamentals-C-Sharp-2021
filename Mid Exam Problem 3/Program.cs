using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "end")
                {
                    foreach (string msg in chat)
                    {
                        Console.WriteLine(msg);
                    }
                    break;
                }
                if (command[0] == "Chat")
                {
                    chat.Add(command[1]);
                }
                if (command[0] == "Delete")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (command[1] == chat[i])
                        {
                            chat.RemoveAt(i);
                            break;
                        }
                    }
                }
                if (command[0] == "Edit")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (command[1] == chat[i])
                        {
                            chat[i] = command[2];
                            break;
                        }
                    }
                }
                if (command[0] == "Pin")
                {
                    for (int i = 0; i < chat.Count; i++)
                    {
                        if (command[1] == chat[i])
                        {
                            chat.RemoveAt(i);
                            break;
                        }
                    }
                    chat.Add(command[1]);
                }
                if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Count; i++)
                    {
                        chat.Add(command[i]);
                    }
                }
            }
        }
    }
}
