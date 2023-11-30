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
        public DbSet<Breakfastfoods> Foods { get; set; }
        public DbSet<Cities> Towns { get; set; }
        public DbSet<Hobbies> Things { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMembers>().HasData(
                new TeamMembers { FullName = " ", Birthdate = new DateTime(), CollegeProgram = " ", YearInProgram = " " }
                );
            modelBuilder.Entity<Breakfastfoods>().HasData(
                new Breakfastfood { BreakfastItemName = " ", Ingredients = " ", Calories = " ", CuisineType = " " }
                );
            modelBuilder.Entity<Cities>().HasData(
                new Cities { FullName = " ", StreetAddress = " ", City = " ", Country = " " }
                );
            modelBuilder.Entity<Hobbies>().HasData(
                new Hobbies { HobbyName = " ", Description = " ", Frequency = " ", Costs = 1 }
                );
        }
    }
}
