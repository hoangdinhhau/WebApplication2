using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EmployeeConText:DbContext
    {
        public EmployeeConText()
        {
        }

        public EmployeeConText(DbContextOptions<EmployeeConText> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
