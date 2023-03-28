using WorkoutGeneratorApp.Data.Contracts;

namespace WorkoutGeneratorApp.Data
{
    public class WorkoutDatabase
    {
        private List<Workout> workoutDatabase;

        public List<Workout> GetWorkouts()
        {
            return workoutDatabase;
        }

        public WorkoutDatabase() => workoutDatabase = WorkoutList();

        public List<Workout> WorkoutList()
        {
            return new List<Workout> {
                new Workout{
                    Id = 1,
                    Description = "EMOM x 20 (for max controlled reps in :40-:50s.)\r\n- Single Heavy DB Supported bent over row\r\n- Single Heavy DB kneeling skull crushers\r\n- Single Heavy DB Front squats (hold on both ends with elbows high)\r\n- Single Heavy DB Good mornings\r\nFinisher\r\nIn unbroken sets complete:\r\n10-9-8-…-3-2-1\r\nSingle DB Curls (hold on ends with both hands)\r\n1-2-3-…-8-9-10\r\nPush ups",
                    Intensity = "Easy",
                    Type = "Fitness"
                },
                new Workout{
                    Id = 2,
                    Description = "5 rounds 45/15s.\r\n- KB Goblet squats\r\n- KB Swings\r\n- Kipping/jumping pull ups\r\n- SU/DU\r\n- Handstand hold",
                    Intensity = "Easy",
                    Type = "Fitness"
                },
                new Workout{
                    Id = 3,
                    Description = "EMOM x 25\r\n- :40-:50s. Cardio of choice\r\n- 10-15 DBL DB Hammer curl to Arnold press\r\n- 12-20 DBL DB Farmer’s forward lunges\r\n- 10-15 Single KB heavy romanian deadlifts\r\n- :40-:50s. For max reps flutter kicks",
                    Intensity = "Hard",
                    Type = "Fitness"
                },
                new Workout{
                    Id = 4,
                    Description = "5 rounds 45/15s.\r\n- Hand release push ups\r\n- Up-downs\r\n- Squat jumps\r\n- Abmat sit-ups\r\n- Active hang",
                    Intensity = "Medium",
                    Type = "Fitness"
                },
                new Workout{
                    Id = 5,
                    Description = "EMOM x 21\r\n- Max cal. Row/AB\r\n- 1 Round of heavy “Macho man”*\r\n- Rest\r\n*Macho man - 3 Power cleans > 3 Front squats > 3 Push jerks\r\nFinisher\r\nEMOM x 8\r\n- 6-10 Strict pull ups/banded\r\n- 6-10 Strict T2B/straight leg raise/knee ups",
                    Intensity = "Hard",
                    Type = "Fitness"
                },
                new Workout{
                    Id = 4,
                    Description = "EMOM x 21\r\n- 1 round of „Cindy“\r\n- 1 round of „DT“**\r\n- 200m. Run\r\n*1 Cindy = 5 Pull ups + 10 Push ups + 15 Air squats\r\n**1 DT = 12 Deadlifts + 9 Hang power cleans + 6 Push jerk/press",
                    Intensity = "Medium",
                    Type = "Fitness"
                }
            };
        }
    }
}
