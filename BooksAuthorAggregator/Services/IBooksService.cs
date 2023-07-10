using BooksAuthorAggregator.Responses;

public interface IBooksService {
    Task<IEnumerable<Books>> GetBooks(Guid authorId);
}