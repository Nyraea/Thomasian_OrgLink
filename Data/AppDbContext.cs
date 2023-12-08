using ThomasianOrglist.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ThomasianOrglist.Data
{
    public class AppDbContext : IdentityDbContext<Student>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        
    }
}
