using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.Services.Employee
{
    public interface IEmpployeeRepository
    {
        //get all employee
        public List<Employees> allEmployees();

        //get employee by id
        public Employees getEmployee(int id);

        //create Employee
        public Employees AddEmployee(Employees employee);
    }
}
