using Microsoft.AspNetCore.Mvc;
using WorkoutGeneratorApp.Interfaces;

namespace WorkoutGeneratorApp.Controllers
{
    [ApiController]
    [Route("v1/workouts")]
    public class WorkoutGeneratorController : ControllerBase
    {
        private readonly IWorkoutApp _workoutApp;

        public WorkoutGeneratorController(IWorkoutApp workoutApp)
        {
            _workoutApp = workoutApp;
        }

        [HttpGet("{workoutId}", Name = "GetWorkout")]
        public IActionResult Get(int workoutId)
        {
            var workout = _workoutApp.GetWorkout(workoutId);
            return Ok(workout);
        }

        [HttpGet(Name = "GetRandomWorkout")]
        public IActionResult GetRandomWorkout()
        {
            var workout = _workoutApp.GetRandomWorkout();
            return Ok(workout);
        }
    }
}