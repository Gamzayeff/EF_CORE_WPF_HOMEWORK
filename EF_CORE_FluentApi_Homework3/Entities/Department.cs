

namespace EF_CORE_FluentApi_Homework3.Entities;

public class Department : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Teacher> Teachers { get; set; }
    public Department() 
    {
    
    }

    
}
