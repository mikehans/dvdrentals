using DTOs;
using Contracts;

namespace data_access;

public class FakeDataOperations : IDataOperations
{
    // Get film list
    public List<FilmDTO> GetFilms()
    {
        return new List<FilmDTO>{
            new FilmDTO{Id=1, Length=91, ReleaseYear="2020", Title="Film 1"},
            new FilmDTO{Id=2, Length=112, ReleaseYear="2017", Title="Film 2"},
            new FilmDTO{Id=3, Length=89, ReleaseYear="2020", Title="Film 3"},
            new FilmDTO{Id=4, Length=100, ReleaseYear="2018", Title="Film 4"},
        };
    }

    // Get inventory items

    // Get inventory for a film

    // Get current loans

    // Get overdue loans

    // Get overdue loans for a customer

}
