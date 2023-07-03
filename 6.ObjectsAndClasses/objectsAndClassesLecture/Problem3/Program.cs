using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= num; i++)
            {
                var input = Console.ReadLine()
                    .Split('_')
                    .ToList();
                string type = input[0];
                string name = input[1];
                string time = input[2];
                //
                var song = new Song(type, name, time);
                //
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                //
                songs.Add(song);
            }
            string order = Console.ReadLine();
            if (order != "all")
            {
                foreach (var item in songs)
                {
                    if (item.TypeList == order)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
