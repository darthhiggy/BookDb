using System.ComponentModel.DataAnnotations;
using BookDb.Data.Models.BaseClasses;

namespace BookDb.Data.Models;

public class PersonNameModel 
{
    public Guid Id { get; set; }
    [MaxLength(25)]
    public string FirstName { get; set; }
    [MaxLength(25)]
    public string LastName { get; set; }
    [MaxLength(25)]
    public string MiddleName { get; set; }
    [MaxLength(5)]
    public string Suffix { get; set; }
    [MaxLength(5)]
    public string Prefix { get; set; }
    [MaxLength(4)]
    public string Title { get; set; }

    public PersonNameModel(string firstName, string lastName, string middleName, string suffix, string prefix, string title)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Suffix = suffix;
        Prefix = prefix;
        Title = title;
    }

    public PersonNameModel()
    {
        
    }
}
