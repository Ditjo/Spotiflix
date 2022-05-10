
namespace Spotiflix
{
    internal class MusicProperties : Media
    {
        public string Artist { get; set; }
        public string Album { get; set; }
    }
    internal class MusicLogic
    {
        internal void MusicLogicAdd()
        {
            MusicProperties musicProperties = new();
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Music";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            musicProperties.Title = tools.GetStringInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            addGraphics.Genre();
            musicProperties.Genre = tools.GetStringInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            addGraphics.Webside();
            musicProperties.Webside = tools.GetStringInput();
            addGraphics.MusicArtist();
            musicProperties.Artist = tools.GetStringInput();
            addGraphics.MusicAlbum();
            musicProperties.Album = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(musicProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        addGraphics.Confirmed(musicProperties.Title);
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
