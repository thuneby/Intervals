namespace Intervals.Core.Models
{
    public class Interval
    {
        public float Lower { get; set; }
        public float Upper { get; set; }

        public Interval(float lower, float upper)
        {
            Lower = lower;
            Upper = upper;
        }
    }
}
