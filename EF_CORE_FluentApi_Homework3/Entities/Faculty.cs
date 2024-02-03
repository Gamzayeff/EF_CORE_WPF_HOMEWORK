using System.Buffers.Text;

namespace EF_CORE_FluentApi_Homework3.Entities;

public class Faculty : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Group> Groups { get; set; }
    public Faculty()
    {

    }

   
}
