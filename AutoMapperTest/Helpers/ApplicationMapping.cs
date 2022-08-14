using AutoMapper;
using AutoMapperTest.Models;
using AutoMapperTestData.assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperTest.Helpers
{
    public class ApplicationMapping : Profile
    {
        public ApplicationMapping()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }
        

    }
}
