using System.ComponentModel.DataAnnotations;

namespace BookDb.Data.Models;

public class GenreModel
{
    public Guid Id { get; set; }
    [MaxLength(25)]
    public string Name { get; set; }
}
