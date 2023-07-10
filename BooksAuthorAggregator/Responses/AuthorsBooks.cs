namespace BooksAuthorAggregator.Responses;


public class AuthorsBooks {

    public Author? author {get; set;}
    public IEnumerable<Books>? books { get; set;}

}

