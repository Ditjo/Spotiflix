using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotiflix
{
    public class MenuGraphics
    {
        internal void MenuMain()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Spotifix.");
            Console.WriteLine("Your new Favorite Streaming platform for everything media related\n");

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Search Media");
            Console.WriteLine("2. Add to library");
            Console.WriteLine("0. Exit Spotifix");
        }
        internal void MenuSearch()
        {
            Console.Clear();
            Console.WriteLine("Where do you want to search:\n");
            Console.WriteLine("1. All Media");
            Console.WriteLine("2. Films");
            Console.WriteLine("3. Series");
            Console.WriteLine("4. Music");
            Console.WriteLine("0. Return to Main Menu");
        }
        internal void MenuAdd()
        {
            Console.Clear();
            Console.WriteLine("What do you want to add to library:\n");
            Console.WriteLine("1. Films");
            Console.WriteLine("2. Series");
            Console.WriteLine("3. Music");
            Console.WriteLine("0. Return to Main Menu");
        }
    }
    internal class MediaGraphics
    {
        internal void Header(string media)
        {
            Console.WriteLine($"Add {media} to library\n");
            //Console.WriteLine("Press esc to return to Main Menu\n");
        }
        internal void Title()
        {
            Console.Write("Title: ");
        }
        internal void Length()
        {
            Console.Write("Length: ");
        }
        internal void Genre()
        {
            Console.Write("Genre: ");
        }
        internal void ReleaseDate()
        {
            Console.Write("Release Date: ");
        }
        internal void Webside()
        {
            Console.Write("Webside: ");
        }
        internal void MusicArtist()
        {
            Console.Write("Artist: ");
        }
        internal void MusicAlbum()
        {
            Console.Write("Album: ");
        }
        internal void SeriesSeason()
        {
            Console.Write("Season: ");
        }
        internal void SeriesEpisode()
        {
            Console.Write("Episode: ");
        }
        internal void SeriesEpisodeTitle()
        {
            Console.Write("Episode Title: ");
        }
        internal void Confirmation(string title)
        {
            Console.WriteLine($"Do you want to add {title} to library? y/n\n");
        }
        internal void Confirmed(string title)
        {
            Console.WriteLine($"{title} has been added to the Library.");
        }
    }
}
