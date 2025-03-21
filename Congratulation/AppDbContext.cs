using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Congratulation.Entities;
using Microsoft.EntityFrameworkCore;
namespace Congratulation
{
   

    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        private readonly string _connectionString;
        private readonly string _dbType;

        public AppDbContext(string dbType, string connectionString)
        {
            _dbType = dbType;
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_connectionString))
            {
                if (_dbType == "SQLServer")
                {
                    optionsBuilder.UseSqlServer(_connectionString);
                }
                else if (_dbType == "Oracle")
                {
                    optionsBuilder.UseOracle(_connectionString);
                }
            }
        }
    }

}
