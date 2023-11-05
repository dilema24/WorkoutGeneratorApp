using Microsoft.EntityFrameworkCore;
using WorkoutGeneratorApp.Data.Contracts;

namespace WorkoutGeneratorApp.Data
{
    public class WorkoutContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=:memory:");
        }
    }
}