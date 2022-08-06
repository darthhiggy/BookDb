using System.ComponentModel.DataAnnotations;

namespace BookDb.Data.Models;

public class EditionModel
{
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(13)]
    public string ISBN { get; set; }
    public PublisherModel PublishedBy { get; set; }
    public DateTime PublishedWhen { get; set; }
    public string Language { get; set; }
    public string Url { get; set; }
    public List<BookModel> Books { get; set; }
}
