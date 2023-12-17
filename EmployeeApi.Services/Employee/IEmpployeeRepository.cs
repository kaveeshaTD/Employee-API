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
        //get all Employee
        public List<Employees> allEmployees();

        //get Employee by id
        public Employees getEmployee(int id);

        //create Employee
        public Employees AddEmployee(Employees employee);

        //Update Employee
        public void UpdateEmployee(Employees employees);

        //delete Employee
        public void DeleteEmployee(Employees employees);
    }
}
