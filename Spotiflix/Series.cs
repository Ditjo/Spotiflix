
namespace Spotiflix
{
    internal class SeriesProperties : Media
    {
        public int Season{ get; set; }
        public int Episode{ get; set; }
        public string EpisodeTitel{ get; set; }
        
    }
    internal class SeriesLogic
    {
        internal void SeriesLogicAdd()
        {
            SeriesProperties seriesProperties = new();
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Series";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            seriesProperties.Title = tools.GetStringInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            addGraphics.Genre();
            seriesProperties.Genre = tools.GetStringInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            addGraphics.Webside();
            seriesProperties.Webside = tools.GetStringInput();
            addGraphics.SeriesSeason();
            seriesProperties.Season = tools.GetIntInput();
            addGraphics.SeriesEpisode();
            seriesProperties.Episode = tools.GetIntInput();
            addGraphics.SeriesEpisodeTitle();
            seriesProperties.EpisodeTitel = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(seriesProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        addGraphics.Confirmed(seriesProperties.Title);
                        Console.ReadKey();
                        exit = false;
                        break;
                    case ConsoleKey.N:
                        //Forget
                        exit = false;
                        break;
                    default:
                        break;
                }
            } while (exit);
        }
    }
}
