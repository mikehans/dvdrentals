using DTOs;

namespace Contracts
{
    public interface IDataOperations
    {
        List<FilmDTO> GetFilms();
        List<FilmDTO> GetFilmByTitle(string title);
        List<FilmDTO> GetFilmByReleaseYear(string year);
    }
}
