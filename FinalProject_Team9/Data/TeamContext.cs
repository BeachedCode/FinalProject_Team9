using Microsoft.EntityFrameworkCore;
using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public class TeamContext:DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options): base(options) { }
        public DbSet<TeamMembers> Member { get; set; }
        public DbSet<Cities> City { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>().HasData(
                new TeamMembers { FullName = "John Smith", Birthdate = new DateTime(2023, 11, 30), CollegeProgram = "IT", YearInProgram = "3rd" },
                new TeamMembers { FullName = "Jane Smith", Birthdate = new DateTime(2003, 5, 15), CollegeProgram = "Cybersecurity", YearInProgram = "1st" }
            );
        }
    }
}
