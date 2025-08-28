// data model for movies in CineMini

namespace CineMini.Models
{
    public class Movie
    {
        // identifier for movie
        public int Id { get; set; }
        // display name for movie
        public string? Title { get; set; }
        // display genre
        public string? Genre { get; set; }
        // year of movie when released
        public int ReleaseYear { get; set; }
        // if true show a featured tag
        public bool IsFeatured { get; set; }
        // if true show a classic tag
        public bool IsClassic { get; set; }
    }
}