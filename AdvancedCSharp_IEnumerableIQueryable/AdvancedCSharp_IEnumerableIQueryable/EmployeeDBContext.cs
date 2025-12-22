using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp_IEnumerableIQueryable
{
    public class EmployeeDBContext : DbContext
    {
        private readonly ILoggerFactory loggerFactory = LoggerFactory.Create(config => config.AddConsole());
        private readonly string connectionString;
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDBContext(string connectionString)
        {
                this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseLoggerFactory(loggerFactory);
            optionBuilder.UseSqlServer(connectionString);
        }
    }
}
