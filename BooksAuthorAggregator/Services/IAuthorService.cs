using BooksAuthorAggregator.Responses;

public interface IAuthorService {
    Task<Author> GetAuthorById(Guid authorId);
}