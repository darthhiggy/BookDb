using System.ComponentModel.DataAnnotations;

namespace BookDb.Data.Models;

public class StoryModel
{
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public List<BookCreatorModel> Creators { get; set; }
    public List<GenreModel> Genres { get; set; }
    public string Description { get; set; }
    [MaxLength(50)]
    public string Series { get; set; }
    public int SeriesOrder { get; set; }
    public List<BookModel> Books { get; set; }
}
