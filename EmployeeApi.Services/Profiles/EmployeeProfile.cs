using AutoMapper;
using EmployeeApi.Models;
using EmployeeApi.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.Services.Profiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile() //class name and this name should be same
        {
            CreateMap<Employees, EmployeeDto>();
            CreateMap<CreateEmployeeDto, Employees>();
            CreateMap<UpdateEmployeeDto, Employees>();//Employees table name
        }
    }
}
