
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
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();

            bool exit = true;
            string media = "Film";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            filmProperties.Title = tools.GetStringInput();
            //mediaGraphics.Length();
            //Insert Method to get length of Film
            addGraphics.Genre();
            filmProperties.Genre = tools.GetStringInput();
            //mediaGraphics.ReleaseDate();
            //Insert Method to get DateTime
            addGraphics.Webside();
            filmProperties.Webside = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(filmProperties.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        addGraphics.Confirmed(filmProperties.Title);
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
