using ThomasianOrglist.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ThomasianOrglist.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    user_id = 1,
                    username = "mjearald123",
                    email = "mark.agraviador.cics@ust.edu.ph",
                    password = "password123",
                    fname = "Mark Jearald",
                    lname = "Agraviador",
                    pnumber = "+639876543210",
                    program = Models.Program.CICS,
                    profile_img = "~/wwwroot/assets/...",
                },
                new Student()
                {
                    user_id = 2,

                    username = "bkirsch123",
                    email = "bea.kirsch.cics@ust.edu.ph",
                    password = "password123",
                    fname = "Beatrice",
                    lname = "Kirsch",
                    pnumber = "+639123456789",
                    program = Models.Program.CFAD,
                    profile_img = "~/wwwroot/assets/..."
                }
                );

        }
    }
}
