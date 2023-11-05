using WorkoutGeneratorApp.Data;
using WorkoutGeneratorApp.Data.Contracts;

namespace WorkoutGeneratorApp.Interfaces
{
    public interface IWorkoutDatabase
    {
        public void SeedDatabase(WorkoutContext context);

        public List<Workout> GetWorkouts();
    }
}