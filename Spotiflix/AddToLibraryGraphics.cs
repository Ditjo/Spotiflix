using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotiflix
{
    internal class AddToLibraryGraphics
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
            Console.Write("Length in sec: ");
        }
        internal void Genre()
        {
            Console.Write("Genre: ");
        }
        internal void ReleaseDate()
        {
            Console.Write("Release Date(yyyy-MM-dd): ");
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
