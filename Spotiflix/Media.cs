
namespace Spotiflix
{
    internal abstract class Media
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Webside { get; set; }
    }
}
