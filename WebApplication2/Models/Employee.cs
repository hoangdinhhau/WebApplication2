using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {
        

        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(60)]
        public string FirstName { get; set; }
        [MaxLength(60)]
        public string LastName { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

       
    }
}
