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
        public List<Employees> allEmployees();
    }
}
