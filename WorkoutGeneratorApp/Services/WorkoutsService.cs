using WorkoutGeneratorApp.Data;
using WorkoutGeneratorApp.Data.Contracts;
using WorkoutGeneratorApp.Interfaces;

namespace WorkoutGeneratorApp.Services
{
    public class WorkoutsService : IWorkoutApp
    {
        private readonly WorkoutDatabase workoutDatabase;

        public WorkoutsService()
        {
            workoutDatabase = new WorkoutDatabase();
        }

        public string GetRandomWorkout()
        {
            var workoutList = workoutDatabase.GetWorkouts();

            Random ran = new();
            var randomInt = ran.Next(workoutList.Count);

            return workoutList[randomInt].Description ;
        }

        public IEnumerable<Workout> GetWorkout(int workoutId)
        {
            var workouts = workoutDatabase.GetWorkouts();

            var workout = workouts.Select(x => x).Where(y => y.Id == workoutId)
                ?? throw new Exception($"Workout with id {workoutId} was not found");

            return workout;
        }
    }
}
