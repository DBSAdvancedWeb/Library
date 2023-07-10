using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksApi.Models;

public class Books {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id {get; set;}

    public Guid AuthorId { get; set; }
    public string? Name {get; set;}
    public string? Isbn {get; set;}
    public string? Category {get; set;}
}