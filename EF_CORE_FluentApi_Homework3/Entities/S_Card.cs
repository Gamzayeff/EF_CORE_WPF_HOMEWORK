
namespace EF_CORE_FluentApi_Homework3.Entities;
public class S_Card : BaseEntity
{
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int LibId { get; set; }
    public Lib Lib { get; set; }
    public S_Card() 
    {
    
    }
}
