using BookDb.Data.Models.BaseClasses;

namespace BookDb.Data.Models;

public class CreatorModel
{
    public long Id { get; set; }
    public PersonNameModel NameModel { get; set; }
    public DateTime DateOfBirth { get; set; }
}
