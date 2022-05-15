
namespace Spotiflix
{
    internal class FilmProperties : Media
    {
        //Same as Media
    }
    internal class FilmLogic
    {
        private string path = @"C:\Spotiflix\Media";

        internal void FilmLogicAdd()
        {
            FilmProperties filmObj = new();
            AddToLibraryGraphics addGraphics = new();
            Tools tools = new();
            FileHandeling fileHandeling = new();

            bool exit = true;
            string media = "Film";

            addGraphics.Header(media);
            //Calls graphics, then input Method. Repeat
            addGraphics.Title();
            filmObj.Title = tools.GetStringInput();
            addGraphics.Length();
            filmObj.Length = tools.GetIntInput();
            addGraphics.Genre();
            filmObj.Genre = tools.GetStringInput();
            addGraphics.ReleaseDate();
            filmObj.ReleaseDate = tools.GetDate();
            addGraphics.Webside();
            filmObj.Webside = tools.GetStringInput();

            //Do you want to add the media to the library
            addGraphics.Confirmation(filmObj.Title);
            do
            {
                //Press y or n key to confirm or decline
                ConsoleKeyInfo confirm = Console.ReadKey(true);
                switch (confirm.Key)
                {
                    case ConsoleKey.Y:
                        //Add
                        fileHandeling.Save(path + @"\Film.json", filmObj);
                        addGraphics.Confirmed(filmObj.Title);
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
        internal void FilmSearch(string searchWord)
        {
            Tools tools = new();
            FileHandeling fileHandeling = new();
            SearchGraphics searchGPU = new();

            List<FilmProperties> filmList = new();
            List<FilmProperties> filmSearchList = new();
            string title, length, genre, releasedate, webside;

            filmList = fileHandeling.LoadFilm(path + @"\Film.json");


            //searchGPU.StartList("Film");
            if(filmList.Count == 0)
            {
                searchGPU.NothingInList();
                Console.ReadKey();
            }
            else
            {
                foreach (var Obj in filmList)
                {
                    title = Obj.Title.ToLower();
                    length = Obj.Length.ToString().ToLower();
                    genre = Obj.Genre.ToLower();
                    releasedate = Obj.ReleaseDate.ToString().ToLower();
                    webside = Obj.Webside.ToLower();
                    if (title == searchWord || length == searchWord || genre == searchWord || releasedate == searchWord || webside == searchWord)
                    {
                        filmSearchList.Add(Obj);
                    }
                }
                if (filmSearchList.Count != 0)
                    searchGPU.PrintFilmList(filmSearchList);
            }
        }
    }
}
