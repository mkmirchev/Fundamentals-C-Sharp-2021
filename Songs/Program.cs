using System;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_',StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                string time = input[2];
                Song song = new Song();
                song.TypeList = type;
                song.name = name;
                song.duration = time;
                songs.Add(song);
            }
            string filter = Console.ReadLine();
            if (filter == "all")
            {
                foreach (var item in songs)
                {
                        Console.WriteLine(item.name);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.TypeList == filter)
                    {
                        Console.WriteLine(item.name);
                    }
                }
            }

        }
    }
    class Song
    {
        public string TypeList { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
    }
}
