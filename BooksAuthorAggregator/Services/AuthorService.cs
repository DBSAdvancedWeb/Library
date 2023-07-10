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
  public class AuthorService : IAuthorService
  {
    private string BASE_URL = "http://localhost:5001/";
    private string API_URL = "/api/v1/authors";
    private readonly HttpClient _httpClient;

    public AuthorService(HttpClient httpClient)
    { 
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(BASE_URL);
    }

    public async Task<Author?> GetAuthorById(Guid authorId)
    {    
        Console.WriteLine(API_URL + "/" + authorId.ToString());  
        return await _httpClient.GetFromJsonAsync<Author>(API_URL + "/" + authorId.ToString()); 
    }

  }     
}