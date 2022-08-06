using System.ComponentModel.DataAnnotations;

namespace BookDb.Data.Models;

public class BookModel
{
    public long Id { get; set; }
    [MaxLength(50)]
    public string Title { get; set; }
    public List<StoryModel> Stories { get; set; }
    public string Url { get; set; }
    public List<EditionModel> Editions { get; set; }
}
