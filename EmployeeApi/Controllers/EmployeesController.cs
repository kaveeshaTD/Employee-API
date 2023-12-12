using AutoMapper;
using EmployeeApi.Services.Employee;
using EmployeeApi.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmpployeeRepository _EmployeeServices;
        private readonly IMapper _mapper;
        public EmployeesController(IEmpployeeRepository repository , IMapper mapper)
        {
            _EmployeeServices = repository;
            _mapper = mapper;
        }

       [HttpGet]
       public ActionResult<ICollection<EmployeeDto>> getEmployees()
        {
            var employees = _EmployeeServices.allEmployees();
            var mapedEmployees = _mapper.Map<ICollection<EmployeeDto>>(employees);
            return Ok(mapedEmployees);
        }
         
    }
}
