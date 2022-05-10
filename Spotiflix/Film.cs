
namespace Spotiflix
{
    internal class FilmProperties : Media
    {
        //Same as Media
    }
    internal class FilmLogic
    {
        internal void FilmLogicAdd()
        {
            FilmProperties filmProperties = new();
            MediaGraphics mediaGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Film";

            mediaGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            mediaGraphics.Title();
            filmProperties.Title = tools.GetInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            mediaGraphics.Genre();
            filmProperties.Genre = tools.GetInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            mediaGraphics.Webside();
            filmProperties.Webside = tools.GetInput();

            //Do you want to add the media to the library
            mediaGraphics.Confirmation(filmProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        mediaGraphics.Confirmed(filmProperties.Title);
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
