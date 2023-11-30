using Microsoft.EntityFrameworkCore;
using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public class TeamContext:DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) :
            base(options)
        { }
        public DbSet<TeamMembers> Members { get; set; }
        public DbSet<Breakfastfood> Foods { get; set; }
        public DbSet<Cities> Towns { get; set; }
        public DbSet<Hobbies> Things { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>().HasData(
                new Product { Id = 1, FullName = " ", BirthDate = 0, CollegeProgram = " ", YearInProgram = " " }
                );
            modelBuilder.Entity<Breakfastfood>().HasData(
                new Product { Id = 1, FullName = " ", BirthDate = 0, CollegeProgram = " ", YearInProgram = " " }
                );
            modelBuilder.Entity<Cities>().HasData(
                new Product { Id = 1, FullName = " ", BirthDate = 0, CollegeProgram = " ", YearInProgram = " " }
                );
            modelBuilder.Entity<Hobbies>().HasData(
                new Product { Id = 1, FullName = " ", BirthDate = 0, CollegeProgram = " ", YearInProgram = " " }
                );
        }
    }
}
