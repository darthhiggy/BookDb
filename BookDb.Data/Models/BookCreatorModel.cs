namespace BookDb.Data.Models;

public class BookCreatorModel
{
    public Guid Id { get; set; }
    public CreatorModel CreatorModel { get; set; }
    public CreatorTypeModel TypeModel { get; set; }
    public StoryModel StoryModel { get; set; }
}
