using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApi.DataAccess
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server =DESKTOP-CNC0FHC; Database = EmployeeDb; Trusted_Connection = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
