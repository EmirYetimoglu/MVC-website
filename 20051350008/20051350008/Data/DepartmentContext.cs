using _20051350008.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _20051350008.Data
{
    public class DepartmentContext : DbContext
    {

        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {
        
        }

        public DbSet<DepartmentModel> Department { get; set; }
    }


}

