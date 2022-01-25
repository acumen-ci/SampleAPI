namespace SampleAPI
{
    public class SampleFilmService : IFilmService
    {
        private readonly List<Film> films = new()
        {
            new Film{Title = "Casablanca", ReleaseDate = new DateTime(1942, 11, 26)},
            new Film{Title = "Double Indemnity", ReleaseDate = new DateTime(1944, 6, 14)},
            new Film{Title = "Sunset Boulevard", ReleaseDate = new DateTime(1950, 8, 10)},
            new Film{Title = "Rear Window", ReleaseDate = new DateTime(1954, 9, 1)},
            new Film{Title = "Lawrence of Arabia", ReleaseDate = new DateTime(1962, 12, 11)},
            new Film{Title = "2001: A Space Odyssey", ReleaseDate = new DateTime(1968, 4, 2)},
            new Film{Title = "The Godfather", ReleaseDate = new DateTime(1972, 3, 14)},
            new Film{Title = "Chinatown", ReleaseDate = new DateTime(1974, 6, 20)},
            new Film{Title = "The Godfather: Part II", ReleaseDate = new DateTime(1974, 12, 20)},
            new Film{Title = "Apocalypse Now", ReleaseDate = new DateTime(1979, 8, 15)},
        };

        public IEnumerable<Film> Find(string title, int? year, bool exactMatch)
        {
            var filmsFilteredByTitle = films.Where(f => exactMatch ? f.Title.Equals(title, StringComparison.OrdinalIgnoreCase) : f.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            return year is null ? filmsFilteredByTitle : filmsFilteredByTitle.Where(f => f.ReleaseDate.Year == year.Value);
        }
    }
}
