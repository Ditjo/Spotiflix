using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Spotiflix
{

    internal class MenuLogic
    {
        public string path = @"C:\Spotiflix\Media";

        public MenuLogic()
        {
            MenuMain();
        }
        
        internal void MenuMain()
        {
            MenuGraphics menuGraphicObj = new();
            
            
            bool exit = true;
            do
            {
                menuGraphicObj.MenuMain();
                ConsoleKeyInfo menu = Console.ReadKey(true);

                switch (menu.Key)
                {
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        exit = false;
                        break;
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        MenuSearch();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        MenuAdd();
                        break;

                    default:
                        break;
                }
            } while (exit);
        }
        internal void MenuSearch()
        {
            MenuGraphics menuGraphicObj = new();
            FileHandeling fileHandeling = new();
            FilmProperties filmObj = new();
            Tools tools = new();
            FilmLogic filmlogic = new();
            MusicLogic musicLogic = new();
            SeriesLogic seriesLogic = new();

            string searchWord;


            
            bool exit = true;
            do
            {
                menuGraphicObj.MenuSearch();
            ConsoleKeyInfo menu = Console.ReadKey(true);
            switch (menu.Key)
            {
                case ConsoleKey.NumPad0:
                case ConsoleKey.D0:
                    exit = false;
                    break;
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                        searchWord = tools.SearchWord().ToLower();
                        filmlogic.FilmSearch(searchWord);
                        seriesLogic.SeriesSearch(searchWord);
                        musicLogic.MusicSearch(searchWord);
                        Console.ReadKey();
                        break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                        searchWord = tools.SearchWord().ToLower();
                        filmlogic.FilmSearch(searchWord);
                        Console.ReadKey();
                        break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                        searchWord = tools.SearchWord().ToLower();
                        seriesLogic.SeriesSearch(searchWord);
                        Console.ReadKey();
                        break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                        searchWord = tools.SearchWord().ToLower();
                        musicLogic.MusicSearch(searchWord);
                        Console.ReadKey();
                        break;

                default:
                    break;
            }
            } while (exit);

        }
        internal void MenuAdd()
        {
            MenuGraphics menuGraphicObj = new();
            
            FilmLogic filmlogic = new();
            MusicLogic musicLogic = new();
            SeriesLogic seriesLogic = new();
            bool exit = true;
            do
            {
                menuGraphicObj.MenuAdd();
                ConsoleKeyInfo menu = Console.ReadKey(true);
                switch (menu.Key)
                {
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.D0:
                        exit = false;
                        break;
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        filmlogic.FilmLogicAdd();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        seriesLogic.SeriesLogicAdd();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        musicLogic.MusicLogicAdd();
                        break;

                    default:
                        break;
                }
            } while (exit);
        }
    }
}
