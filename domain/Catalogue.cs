using Contracts;
using data_access;
using DTOs;

namespace domain;

/*
    Domain objects
    - catalogue (what videos are in which stores and how many copies)
    - borrowings (who has what on loan and when are they due)
    - membership (customers, addresses)
    - ccompany (inc. staff and stores)

*/
public class Catalogue
{
    // list of films (the catalogue)
    public List<FilmDTO> RetrieveCatalogue(){
        IDataOperations repo = new FakeDataOperations();
        return repo.GetFilms();
    }

    // list of categories
    // each film has one or more categories
    // held copies of each film, where they are and if they are on shelf or on loan (show due date)

    // a user should be able to:
    //  - get a list of all films 
    //  - search films by category
    //  - see where a film is held and whether it is available or is on loan (showing due date)
    //  - search for films by actor
}

public class Borrowings
{
    // borrowing history of customers
    // loan status of each film, inc. due date and return status
}
