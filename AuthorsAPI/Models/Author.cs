using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorsAPI.Models;

public class Author
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Biography {get; set;}
    public DateTime? Born {get; set;}

}
