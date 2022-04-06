using DTOs;

namespace Contracts
{
    public interface ICatalogue
    {
         List<FilmDTO> RetrieveCatalogue();
         List<FilmDTO> RetrieveTitle(string title);
         List<FilmDTO> RetrieveFilmsInYear(string year);
    }
}