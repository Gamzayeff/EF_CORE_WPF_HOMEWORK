
namespace EF_CORE_FluentApi_Homework3.Entities;

public class Book : BaseEntity
{
    public string? Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public string? Comment { get; set; } 
    public int Quantity { get; set; }
    public int ThemeId { get; set; }
    public Theme Theme { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public int PresId { get; set; }
    public Pres Pres { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
    public Book() 
    {
    
    }

    
}
