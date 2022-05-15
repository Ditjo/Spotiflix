using System.Text.Json;

namespace Spotiflix
{
    internal class FileHandeling
    {
        //Converts objects to Json & writes it int a file
        internal void Save(string path, object data)
        {
            string json = JsonSerializer.Serialize(data);

            File.AppendAllText(path, json + Environment.NewLine);
        }
        internal String[] ReadFile(string path)
        {
            string[]? array = File.ReadAllLines(path);
            return array;
        }
        //Reads the file via the path & converts JSON to FilmObj
        internal List<FilmProperties> LoadFilm(string path)
        {
            List<FilmProperties> list = new();
            string[]? array = ReadFile(path);
            foreach (var item in array)
            {
                list.Add(JsonSerializer.Deserialize<FilmProperties>(item));
            }
            return list;
        }
        //Reads the file via the path & converts JSON to SeriesObj
        internal List<SeriesProperties> LoadSeries(string path)
        {
            List<SeriesProperties> list = new();
            string[]? array = ReadFile(path);
            foreach (var item in array)
            {
                list.Add(JsonSerializer.Deserialize<SeriesProperties>(item));
            }
            return list;
        }
        //Reads the file via the path & converts JSON to MusicObj
        internal List<MusicProperties> LoadMusic(string path)
        {
            List<MusicProperties> list = new();
            string[]? array = ReadFile(path);
            foreach (var item in array)
            {
                list.Add(JsonSerializer.Deserialize<MusicProperties>(item));
            }
            return list;
        }
    }
}
