using WorkoutGeneratorApp.Data;
using WorkoutGeneratorApp.Interfaces;

namespace WorkoutGeneratorApp.Services
{
    public class BcFitWorkoutApp : IWorkoutApp
    {
        private readonly WorkoutDatabase workoutDatabase;

        public BcFitWorkoutApp()
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
    }
}
