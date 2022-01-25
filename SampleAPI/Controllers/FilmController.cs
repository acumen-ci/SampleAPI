using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("Film")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService filmService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        [HttpPost("Search")]
        public IEnumerable<Film> Search(SearchOptions options)
        {
            return filmService.Find(title: options.Title, year: options.Year, exactMatch: true);
        }
    }

    public class SearchOptions
    {
        public string Title { get; set; } = "";
        public int? Year { get; set; }
    }
}