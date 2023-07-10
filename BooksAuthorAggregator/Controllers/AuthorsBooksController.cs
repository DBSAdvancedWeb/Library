using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BooksAuthorAggregator.Responses;
using BooksAuthorAggregator.Services;

namespace BooksAuthorAggregator.Controllers;

[ApiController]
[Route("api/v1/authorsbooks")]
public class AuthorsBooksController : ControllerBase
{


    private readonly ILogger<AuthorsBooksController> _logger;

    private readonly AuthorService _authorService;
    private readonly BooksService _booksService;
    

    public AuthorsBooksController(ILogger<AuthorsBooksController> logger, AuthorService authorService, BooksService booksService)
    {
        _logger = logger;
        _authorService = authorService;
        _booksService = booksService;
    }

    [HttpGet]
    public async Task<AuthorsBooks> GetAuthorsBooks(Guid authorId)
    {

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        var authorObj = await _authorService.GetAuthorById(authorId);
        var authorsBooks = await _booksService.GetBooks(authorId);

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

        return new AuthorsBooks{
            author = authorObj,
            books = authorsBooks    
        };
    }
}
