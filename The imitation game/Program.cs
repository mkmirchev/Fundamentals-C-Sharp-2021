using System;
using System.Linq;
namespace The_imitation_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Decode")
                {
                    Console.WriteLine($"The decrypted message is: {encryptedMsg}");
                    break;
                }
                if (input.Contains("ChangeAll"))
                {
                    string[] srt = input.Split('|').ToArray();
                    char a = char.Parse(srt[1]); //substring
                    char b = char.Parse(srt[2]); //replacement
                    string output = string.Empty;
                    for (int i = 0; i < encryptedMsg.Length; i++)
                    {
                        if (encryptedMsg[i] == a)
                        {
                            output += b;
                        }
                        else
                        {
                            output += encryptedMsg[i];
                        }
                    }
                    encryptedMsg = output;
                }
                if (input.Contains("Insert"))
                {
                    string output = encryptedMsg;
                    string[] str = input.Split('|').ToArray();
                    int a = int.Parse(str[1]); //index
                    encryptedMsg = output.Insert(a, str[2]);
                }
                if (input.Contains("Move"))
                {
                    string[] srt = input.Split('|').ToArray();
                    int a = int.Parse(srt[1]);
                    string charsToMove = string.Empty;
                    string newStr = string.Empty;
                    for (int i = 0; i < a; i++)
                    {
                        charsToMove += encryptedMsg[i];
                    }
                    for (int j = a; j < encryptedMsg.Length; j++)
                    {
                        newStr += encryptedMsg[j];
                    }
                    encryptedMsg = newStr + charsToMove;
                }
            }
        }
    }
}
