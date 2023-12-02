using ThomasianOrglist.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ThomasianOrglist.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Department> Departments { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "FACULTY OF ARTS AND LETTERS" },
            new Department { Id = 2, Name = "COLLEGE OF COMMERCE AND BUSINESS ADMINISTRATION" },
            new Department { Id = 3, Name = "COLLEGE OF EDUCATION" },
            new Department { Id = 4, Name = "AMV COLLEFE OF ACCOUNTANCY" },
            new Department { Id = 5, Name = "COLLEGE OF TOURISM AND HOSPITALITY MANAGEMENT" },
            new Department { Id = 6, Name = "COLLEGE OF ARCHITECTURE" },
            new Department { Id = 7, Name = "COLLEGE OF INFORMATION AND COMPUTING SCIENCE" },
            new Department { Id = 8, Name = "COLLEGE OF FINE ARTS AND DESIGN" },
            new Department { Id = 9, Name = "FACULTY OF ENGINEERING" },
            new Department { Id = 10, Name = "COLLEGE OF NURSING" },
            new Department { Id = 11, Name = "FACULTY OF PHARMACY" },
            new Department { Id = 12, Name = "FACULTY OF MEDICINE AND SURGERY" },
            new Department { Id = 13, Name = "UNIVERSITY WIDE ORGANIZATIONS" }
            );

            modelBuilder.Entity<Organization>().HasData(
            new Organization { org_id = 1, OrgName = "Artistang Artlets",
                emailAdd = "ijaso2002@ust.edu.ph",
                Password = "hatdog13!",
                Vision ="aowdaowdbaw", 
                Mission="awubdauwbdub", 
                Details = "Artistang Artlets (AA), the Recognized Theater Guild of the Faculty of Arts and Letters of " +
               "the University of Santo Tomas has been active servants and promoters of art for the past 42 years. ",
                DepartmentId = 1 },
            new Organization { org_id = 2, OrgName = "Artlets Economic Society",
                emailAdd = "ijason2002@ust.edu.ph",
                Password = "hatdog12!",
                Vision = "aowdaowdbaw",
                Mission = "awubdauwbdub",
                Details ="The Artlets Economics Society of the UST Faculty of Arts and Letters, ever persevering in its goals to provide empowered and inspired " +
                "Thomasian economists to the Philippine society, which was established by her forefathers in 1975, has continually maintained her legacy of dynamism, " +
                "intellect, and compassion in order to fully realize her vision of an enlightened Filipino nation for all.\r\n" ,
                DepartmentId = 1 }
           // new Organization { org_id = 3, OrgName = "UST Journalism Society", DepartmentId = 1 },

           // new Organization { org_id = 4, OrgName = "Thomasian Junior Association for People Management", DepartmentId = 2 },
            //new Organization { org_id = 5, OrgName = "UST Economics Society", DepartmentId = 2 },
            //new Organization { org_id = 6, OrgName = "UST Junior Marketing Association", DepartmentId = 2 }

            //new Organization { org_id = 7, OrgName = "Info & Computing Org 1", DepartmentId = 3 }
            // Add more organizations as needed
        );

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
