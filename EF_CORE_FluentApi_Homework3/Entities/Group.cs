namespace EF_CORE_FluentApi_Homework3.Entities;

public class Group : BaseEntity
{
    public string? Name { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    public ICollection<Student> Students { get; set; }
    
    public Group() 
    {
    
    }

}
