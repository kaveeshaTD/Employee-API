using AutoMapper;
using EmployeeApi.Models;
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
        public EmployeesController(IEmpployeeRepository repository, IMapper mapper)
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

        //get select emp
        [HttpGet("{Id}", Name = "GetEmployee")]
        public IActionResult getEmployee(int id)
        {
            var Employee = _EmployeeServices.getEmployee(id);
            if(Employee is null)
            {
                return NotFound();
            }
            var mappedEmployee = _mapper.Map<EmployeeDto>(Employee);
            return Ok(mappedEmployee);
        }

        [HttpPost]
        public ActionResult<EmployeeDto> CreateEmployee(CreateEmployeeDto employee)
        {
            var employeeEntity = _mapper.Map<Employees>(employee);
            var newEmployee = _EmployeeServices.AddEmployee(employeeEntity);
            var employeeForReturn = _mapper.Map<EmployeeDto>(newEmployee);

            return CreatedAtRoute("GetEmployee" , new {id=employeeForReturn.Id},employeeForReturn);
        }
         
        [HttpPut("{EmployeeID}")]
        public ActionResult UpdateEmployee(int employeeID , UpdateEmployeeDto employee)
        {
            var updatingEmployee = _EmployeeServices.getEmployee(employeeID);
            if(updatingEmployee is null)
            {
                return NotFound();
            }
            _mapper.Map(employee, updatingEmployee);
            _EmployeeServices.UpdateEmployee(updatingEmployee);
            return NoContent();
        }

        [HttpDelete("{EmployeeID}")]
        public ActionResult DeleteEmployee(int employeeID)
        {
            var deletingEmployee = _EmployeeServices.getEmployee(employeeID);
           if(deletingEmployee is null)
            {
                return NotFound();
            }
            _EmployeeServices.DeleteEmployee(deletingEmployee);
            return NoContent();

        }
    }
}
