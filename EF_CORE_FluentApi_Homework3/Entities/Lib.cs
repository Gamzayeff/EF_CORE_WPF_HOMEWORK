

namespace EF_CORE_FluentApi_Homework3.Entities;

public class Lib : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public ICollection<T_Card> T_Cards { get; set; }
    public ICollection<S_Card> S_Cards { get; set; }
    public Lib()
    {
    
    }


}
