
namespace Spotiflix
{
    internal class MusicProperties : Media
    {
        public string Artist { get; set; }
        public string Album { get; set; }
    }
    internal class MusicLogic
    {
        private string path = @"C:\Spotiflix\Media";
        internal void MusicLogicAdd()
        {
            MusicProperties musicObj = new();
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();
            FileHandeling fileHandeling = new();

            bool exit = true;
            string media = "Music";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            musicObj.Title = tools.GetStringInput();
            addGraphics.Length();
            musicObj.Length = tools.GetIntInput();
            addGraphics.Genre();
            musicObj.Genre = tools.GetStringInput();
            addGraphics.ReleaseDate();
            musicObj.ReleaseDate = tools.GetDate();
            addGraphics.Webside();
            musicObj.Webside = tools.GetStringInput();
            addGraphics.MusicArtist();
            musicObj.Artist = tools.GetStringInput();
            addGraphics.MusicAlbum();
            musicObj.Album = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(musicObj.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        fileHandeling.Save(path + @"\Music.json", musicObj);
                        addGraphics.Confirmed(musicObj.Title);
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
        internal void MusicSearch(string searchWord)
        {
            Tools tools = new();
            FileHandeling fileHandeling = new();
            SearchGraphics searchGPU = new();

            List<MusicProperties> musicList = new();
            List<MusicProperties> musicSearchList = new();
            string title, length, genre, releasedate, webside, artist, album;

            musicList = fileHandeling.LoadMusic(path + @"\Music.json");

            //searchGPU.StartList("Music");
            if (musicList.Count == 0)
            {
                searchGPU.NothingInList();
                Console.ReadKey();
            }
            else
            {
                foreach (var Obj in musicList)
                {
                    title = Obj.Title.ToLower();
                    length = Obj.Length.ToString().ToLower();
                    genre = Obj.Genre.ToLower();
                    artist = Obj.Artist.ToLower();
                    album = Obj.Album.ToLower();
                    releasedate = Obj.ReleaseDate.ToString().ToLower();
                    webside = Obj.Webside.ToLower();

                    if (title == searchWord || length == searchWord || genre == searchWord || releasedate == searchWord || webside == searchWord || artist == searchWord || album == searchWord)
                    {
                        musicSearchList.Add(Obj);
                    }
                }
                if (musicSearchList.Count != 0)
                    searchGPU.PrintMusicList(musicSearchList);
            }
        }
    }
}
