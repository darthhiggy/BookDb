using System.ComponentModel.DataAnnotations;

namespace BookDb.Data.Models;

public class CreatorTypeModel
{
    public long Id { get; set; }
    [MaxLength(25)]
    public string Name { get; set; }
}
