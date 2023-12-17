using EmployeeApi.DataAccess;
using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.Services.Employee
{
    public class EmployeeSqlServices : IEmpployeeRepository
    {
        public readonly EmployeeDbContext _context = new EmployeeDbContext();
         public List<Employees>allEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employees getEmployee(int id)
        {
            return _context.Employees.Find(id); //in this line employees mean employee table
        }

        //create employee
        public Employees AddEmployee(Employees employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.Find(employee.Id);
        }

        //update employee
        public void UpdateEmployee(Employees employees)
        {
            _context.SaveChanges();
        }

        //delete Employee
        public void DeleteEmployee(Employees employees)
        {
            _context.Remove(employees);
            _context.SaveChanges();

        }
    }
}
