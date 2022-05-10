
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
            MediaGraphics mediaGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Music";

            mediaGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            mediaGraphics.Title();
            musicProperties.Title = tools.GetInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            mediaGraphics.Genre();
            musicProperties.Genre = tools.GetInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            mediaGraphics.Webside();
            musicProperties.Webside = tools.GetInput();
            mediaGraphics.MusicArtist();
            musicProperties.Artist = tools.GetInput();
            mediaGraphics.MusicAlbum();
            musicProperties.Album = tools.GetInput();

            //Do you want to add the media to the library
            mediaGraphics.Confirmation(musicProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        mediaGraphics.Confirmed(musicProperties.Title);
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
