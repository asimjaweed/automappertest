using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperTest.Models
{
    public class EmployeeModel
    {

            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string ConfirmEmail { get; set; }
            public DateTime DateOfBrith { get; set; }
           // public Gender Gender { get; set; }
           // public int? DepartmentId { get; set; }
            //public string PhotoPath { get; set; }
           // public Department Department { get; set; } = new Department();
        }
    }

