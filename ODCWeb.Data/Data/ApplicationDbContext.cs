using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using ODCWeb.Models;


namespace ODCWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ODCProject> Projects { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<Floor>().HasData(
                new Floor { FloorId = 1, Name = "Basement" },
                new Floor { FloorId = 2, Name = "First Floor" },
                new Floor { FloorId = 3, Name = "Second Floor" },
                new Floor { FloorId = 4, Name = "Third Floor" },
                new Floor { FloorId = 5, Name = "Forth Floor" },
                new Floor { FloorId = 6, Name = "Fifth Floor" },
                new Floor { FloorId = 7, Name = "Sixth Floor" },
                new Floor { FloorId = 8, Name = "Eighth Floor" }
                );*/

        }
    }
}
