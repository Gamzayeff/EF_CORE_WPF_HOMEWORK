using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_FluentApi_Homework3.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }   
    public BaseEntity() 
    {
    
    }
}
