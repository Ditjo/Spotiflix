
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
            MediaGraphics mediaGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Series";

            mediaGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            mediaGraphics.Title();
            seriesProperties.Title = tools.GetInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            mediaGraphics.Genre();
            seriesProperties.Genre = tools.GetInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            mediaGraphics.Webside();
            seriesProperties.Webside = tools.GetInput();
            //mediaGraphics.SeriesSeason();
            //seriesProperties.Season =
            //mediaGraphics.SeriesEpisode();
            //seriesProperties.Episode =
            mediaGraphics.SeriesEpisodeTitle();
            seriesProperties.EpisodeTitel = tools.GetInput();

            //Do you want to add the media to the library
            mediaGraphics.Confirmation(seriesProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        mediaGraphics.Confirmed(seriesProperties.Title);
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
