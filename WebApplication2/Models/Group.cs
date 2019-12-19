using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Group
    {
        public Group()
        {
            Employee = new List<Employee>();
        }
        public int GroupId { get; set; }
        [Required]
        [MaxLength(60)]
        public string GroupName { get; set; }
        public List<Employee> Employee { get; set; }
       
         
    }
    
}
