

namespace EF_CORE_FluentApi_Homework3.Entities;

public class Student : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public string? Term { get; set;}
    public int GroupId { get; set; }
    public Group Group { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
    public Student() 
    {
    
    }

}
