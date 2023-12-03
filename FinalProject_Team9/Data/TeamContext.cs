using Microsoft.EntityFrameworkCore;
using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public class TeamContext:DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options): base(options) { }
        public DbSet<TeamMembers> Member { get; set; }
        public DbSet<Cities> City { get; set; }
        public DbSet<Hobbies> hobbies { get; set; }

        public DbSet<Breakfastfood> breakfastfood { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TEAM MEMBERS//
            modelBuilder.Entity<TeamMembers>().HasData(
                new TeamMembers { Id = 1, FullName = "Ethan Beach", Birthdate = new DateTime(2002, 8, 6), CollegeProgram = "IT", YearInProgram = "3rd" },
                new TeamMembers { Id = 2, FullName = "Calvin Yeboah", Birthdate = new DateTime(2004,3,25), CollegeProgram = "Computer Science", YearInProgram = "1st"},
                new TeamMembers { Id = 3, FullName = "Ethan White", Birthdate = new DateTime(2003, 5, 21), CollegeProgram = "IT", YearInProgram = "3rd" },
                new TeamMembers { Id = 4, FullName = "Donald Durgan", Birthdate=new DateTime(2003, 9, 21), CollegeProgram = "IT", YearInProgram = "2nd" }
            );



            //BREAKFAST//
            modelBuilder.Entity<Breakfastfood>().HasData
                (new Breakfastfood { Id = 3, BreakfastItemName = "Pancakes", Calories = "200", CuisineType = "Pancake", Ingredients = "Flour" });




            //HOBBIES//
            modelBuilder.Entity<Hobbies>().HasData
                (new Hobbies { Id = 3, HobbyName = "Soccer", Costs = 200, Description = "Playing Soccer", Frequency = "Regular" });



            //CITIES//
            modelBuilder.Entity<Cities>().HasData
                (new Cities { Id = 3, FullName = "Calvin Yeboah", Country = "France", City = "Paris" , StreetAddress = " 224 marsille st"});



           

       

        }
    }
}
