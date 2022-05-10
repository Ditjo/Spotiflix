using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotiflix
{

    public class MenuLogic
    {
        internal void MenuMain()
        {
            MenuGraphics menuGraphicObj = new();
            MenuLogic menuLogicObj = new();
            
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
                        menuLogicObj.MenuSearch();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        menuLogicObj.MenuAdd();
                        break;

                    default:
                        break;
                }
            } while (exit);
        }
        internal void MenuSearch()
        {
            MenuGraphics menuGraphicObj = new();
            MenuLogic menuLogicObj = new();
            Tools tools = new Tools();//<----------Delete later
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
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    break;

                default:
                    break;
            }
            } while (exit);

        }
        internal void MenuAdd()
        {
            MenuGraphics menuGraphicObj = new();
            MenuLogic menuLogicObj = new();
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
