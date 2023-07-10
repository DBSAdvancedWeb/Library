using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BooksAuthorAggregator.Responses;
using BooksAuthorAggregator.Services;
using System.Net.Http.Json;
using System.Reflection;

namespace BooksAuthorAggregator.Services
{
  public class BooksService : IBooksService
  {
    private string BASE_URL = "http://localhost:5002/";
    private string API_URL = "/api/v1/books";
    private readonly HttpClient _httpClient;

    public BooksService(HttpClient httpClient)
    { 
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(BASE_URL);
    }

    public async Task<IEnumerable<Books>?> GetBooks(Guid authorId)
    {      
        return await _httpClient.GetFromJsonAsync<IEnumerable<Books>>(API_URL + "?authorId=" + authorId); 
    }

  }     
}