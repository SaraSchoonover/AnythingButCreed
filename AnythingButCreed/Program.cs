using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
            new Song("Creed", "Higher"),
            new Song("Creed", "This Is A Song"),
            new Song("Creed", "IDK"),
            new Song("Brandy", "Sitting Up In My Room"),
            new Song("Beter Oblivion Community Center", "Dylan Thomas"),
            new Song("Modest Mouse", "Florida"),
            new Song("The Menzingers", "Good Things"),
            new Song("Rilo Kiley", "With Arms Outstretched"),
            new Song("Television", "Marquee Moon"),
            new Song("Dolly Parton", "Two Doors Down"),
            new Song("Haim", "Now I'm In It"),
            new Song("Your Smith", "Debbie")
            };

            goodSongs.AddRange(allSongs.Where(song => song.Artist != "Creed"));

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} {song.Name}");
            }
        }
    }
}
