namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;
        private const double LapLengthInMeters = 50;
        private const double MetersToMiles = 0.000621371;

        public Swimming(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance() => laps * LapLengthInMeters * MetersToMiles;
        public override double GetSpeed() => (GetDistance() / Minutes) * 60;
        public override double GetPace() => Minutes / GetDistance();
    }
}