using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _20051350008.Models;
using Microsoft.Extensions.Options;
namespace _20051350008.Data
{
    public class VolunteerContext : DbContext
    {
        public VolunteerContext(DbContextOptions<VolunteerContext> options) : base(options)
        {

        }
        public DbSet<VolunteerModel> Volunteer { get; set; }

    }
}
