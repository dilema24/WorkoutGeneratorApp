using WorkoutGeneratorApp.Data.Contracts;

namespace WorkoutGeneratorApp.Interfaces
{
    public interface IWorkoutApp
    {
        public IEnumerable<Workout> GetWorkout(int workoutId);
        public string GetRandomWorkout();
    }
}
