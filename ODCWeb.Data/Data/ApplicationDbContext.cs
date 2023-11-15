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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*modelBuilder.Entity<ODCProject>().HasData(
                new ODCProject { Id = 1, Name = "Action", Location = "Lahore" },
                new ODCProject { Id = 2, Name = "SciFi", Location = "Islamabad" },
                new ODCProject { Id = 3, Name = "History", Location = "Karachi" }
                );*/

        }
    }
}
