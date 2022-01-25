namespace SampleAPI
{
    public interface IFilmService
    {
        IEnumerable<Film> Find(string title, int? year, bool exactMatch);
    }
}