
namespace EF_CORE_FluentApi_Homework3.Entities;
public class Theme : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Book> Books { get; set; }
    public Theme()
    {
    
    }
}
