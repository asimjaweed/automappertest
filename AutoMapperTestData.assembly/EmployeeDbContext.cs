using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperTestData.assembly
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}
