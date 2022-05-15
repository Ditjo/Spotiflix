using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Spotiflix
{
    //graphics for when you search for a media
    internal class SearchGraphics
    {
        internal void NothingInList()
        {
            Console.WriteLine("Nothing in list");
        }
        internal void SearchWord()
        {
            Console.Write("Enter Search Term: ");
        }
        internal void StartList(string type)
        {
            Console.WriteLine($"***** {type} List *****");
        }
        //Prints List of films with the Search term
        internal void PrintFilmList(List<FilmProperties> list)
        {
            int h, m;
            StartList("Film");
            Console.WriteLine("");
            foreach (var Obj in list)
            {
                h = (Obj.Length / 3600);
                m = (Obj.Length - (3600*h))/60;
                Console.WriteLine($"--------------------------\n" +
                    $"Title: {Obj.Title}\n" +
                    $"Length: {h} Hours {m} Minutes\n" +
                    $"Genre: {Obj.Genre}\n" +
                    $"Release date: {Obj.ReleaseDate.ToString("yyyy/MM/dd")}\n" +
                    $"Webside: {Obj.Webside}");
            }
            Console.WriteLine($"--------------------------\n");
        }
        //Prints List of Series with the Search term
        internal void PrintSeriesList(List<SeriesProperties> list)
        {
            int m;
            StartList("Series");
            Console.WriteLine("");
            foreach (var Obj in list)
            {
                m = (Obj.Length / 60);
                Console.WriteLine($"--------------------------\n" +
                    $"Title: {Obj.Title}\n" +
                    $"Length: {m} Minutes\n" +
                    $"Genre: {Obj.Genre}\n" +
                    $"Season: {Obj.Season}\n" +
                    $"Episode: {Obj.Episode}\n" +
                    $"Episode Title: {Obj.EpisodeTitel}\n" +
                    $"Release date: {Obj.ReleaseDate.ToString("yyyy/MM/dd")}\n" +
                    $"Webside: {Obj.Webside}");
            }
            Console.WriteLine($"--------------------------\n");
        }
        //Prints List of music with the Search term
        internal void PrintMusicList(List<MusicProperties> list)
        {
            int m, s;
            StartList("Music");
            Console.WriteLine("");
            foreach (var Obj in list)
            {
                m = (Obj.Length / 60);
                s = (Obj.Length - (m*60));
                Console.WriteLine($"--------------------------\n" +
                    $"Title: {Obj.Title}\n" +
                    $"Length: {m} Minutes {s} seconds\n" +
                    $"Genre: {Obj.Genre}\n" +
                    $"Artist: {Obj.Artist}\n" +
                    $"Album: {Obj.Album}\n" +
                    $"Release date: {Obj.ReleaseDate.ToString("yyyy/MM/dd")}\n" +
                    $"Webside: {Obj.Webside}");
            }
            Console.WriteLine($"--------------------------\n");
        }
    }
}
