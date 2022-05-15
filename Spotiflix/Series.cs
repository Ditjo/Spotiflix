
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
        private string path = @"C:\Spotiflix\Media";
        internal void SeriesLogicAdd()
        {
            SeriesProperties seriesObj = new();
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();
            FileHandeling fileHandeling = new();

            bool exit = true;
            string media = "Series";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            seriesObj.Title = tools.GetStringInput();
            addGraphics.Length();
            seriesObj.Length = tools.GetIntInput();
            addGraphics.Genre();
            seriesObj.Genre = tools.GetStringInput();
            addGraphics.ReleaseDate();
            seriesObj.ReleaseDate = tools.GetDate();
            addGraphics.Webside();
            seriesObj.Webside = tools.GetStringInput();
            addGraphics.SeriesSeason();
            seriesObj.Season = tools.GetIntInput();
            addGraphics.SeriesEpisode();
            seriesObj.Episode = tools.GetIntInput();
            addGraphics.SeriesEpisodeTitle();
            seriesObj.EpisodeTitel = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(seriesObj.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        fileHandeling.Save(path + @"\Series.json", seriesObj);
                        addGraphics.Confirmed(seriesObj.Title);
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
        internal void SeriesSearch(string searchWord)
        {
            Tools tools = new();
            FileHandeling fileHandeling = new();
            SearchGraphics searchGPU = new();

            List<SeriesProperties> seriesList = new();
            List<SeriesProperties> seriesSearchList = new();
            string title, length, genre, releasedate, webside, season, episode, episodetitle;

            seriesList = fileHandeling.LoadSeries(path + @"\Series.json");


            //searchGPU.StartList("Series");
            if (seriesList.Count == 0)
            {
                searchGPU.NothingInList();
                Console.ReadKey();
            }
            else
            {
                foreach (var Obj in seriesList)
                {
                    title = Obj.Title.ToLower();
                    length = Obj.Length.ToString().ToLower();
                    genre = Obj.Genre.ToLower();
                    season = Obj.Season.ToString().ToLower();
                    episode = Obj.Episode.ToString().ToLower();
                    episodetitle = Obj.EpisodeTitel.ToLower();
                    releasedate = Obj.ReleaseDate.ToString().ToLower();
                    webside = Obj.Webside.ToLower();
                    if (title == searchWord || length == searchWord || genre == searchWord || releasedate == searchWord || webside == searchWord || season == searchWord || episode == searchWord || episodetitle == searchWord)
                    {
                        seriesSearchList.Add(Obj);
                    }
                }
                if(seriesSearchList.Count != 0)
                searchGPU.PrintSeriesList(seriesSearchList);
            }
        }
    }
}
