
namespace EF_CORE_FluentApi_Homework3.Entities;
public class Teacher : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<T_Card> T_Cards{ get; set; }
    public Teacher() 
    {
    
    }

}
