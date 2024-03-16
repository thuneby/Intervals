using Intervals.Core.Models;

namespace Intervals.Core.Functions
{
    public class Arithmetic
    {
        public Interval ISum(Interval a, Interval b)
        {
            return new Interval(a.Lower + b.Lower, a.Upper + b.Upper);
        }

        public Interval ISub(Interval a, Interval b)
        {
            return new Interval(a.Lower - b.Upper, a.Upper - b.Lower);
        }

        public Interval IMul(Interval a, Interval b)
        {
            float[] products = { a.Lower * b.Lower, a.Lower * b.Upper, a.Upper * b.Lower, a.Upper * b.Upper };
            return new Interval(products.Min(), products.Max());
        }

        public Interval IDiv(Interval a, Interval b)
        {
            if (b.Lower <= 0 && b.Upper >= 0)
            {
                return new Interval(float.NegativeInfinity, float.PositiveInfinity);
            }
            float[] quotients = { a.Lower / b.Lower, a.Lower / b.Upper, a.Upper / b.Lower, a.Upper / b.Upper };
            return new Models.Interval(quotients.Min(), quotients.Max());
        }

        public float IWidth(Models.Interval a)
        {
            return a.Upper - a.Lower;
        }

    }
}
