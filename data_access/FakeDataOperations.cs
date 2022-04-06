using DTOs;
using Contracts;
using System.Linq;

namespace data_access;

public class FakeDataOperations : IDataOperations
{
    List<FilmDTO> films = new List<FilmDTO>{
            new FilmDTO{Id=1, Length=91, ReleaseYear="2020", Title="Film 1"},
            new FilmDTO{Id=2, Length=112, ReleaseYear="2017", Title="Film 2"},
            new FilmDTO{Id=3, Length=89, ReleaseYear="2020", Title="Film 3"},
            new FilmDTO{Id=4, Length=100, ReleaseYear="2018", Title="Film 4"},
        };
    // Get film list
    public List<FilmDTO> GetFilms()
    {
        return films;
    }

    // Get film by title (partial)
    public List<FilmDTO> GetFilmByTitle(string title)
    {
        // return films.FindAll(f => f.Title == title);
        return GetFilms(f => f.Title.ToLower() == title.ToLower());
    }

    // Get film by release year
    public List<FilmDTO> GetFilmByReleaseYear(string releaseYear)
    {
        return GetFilms(f => f.ReleaseYear.ToLower() == releaseYear.ToLower());
    }

    private List<FilmDTO> GetFilms(Predicate<FilmDTO> predicate)
    {
        return films.FindAll(predicate);
    }
    // Get inventory items

    // Get inventory for a film

    // Get current loans

    // Get overdue loans

    // Get overdue loans for a customer

}
