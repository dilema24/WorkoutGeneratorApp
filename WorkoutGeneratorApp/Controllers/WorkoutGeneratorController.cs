using Microsoft.AspNetCore.Mvc;
using WorkoutGeneratorApp.Interfaces;

namespace WorkoutGeneratorApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutGeneratorController : ControllerBase
    {
        private readonly ILogger<WorkoutGeneratorController> _logger;
        private IWorkoutApp _workoutApp;

        public WorkoutGeneratorController(IWorkoutApp workoutApp ,ILogger<WorkoutGeneratorController> logger)
        {
            _workoutApp = workoutApp;
            _logger = logger;
        }

        [HttpGet(Name = "GetWorkout")]
        public IActionResult Get()
        {
            var workout = _workoutApp.GetRandomWorkout();
            return Ok(workout);
        }
    }
}