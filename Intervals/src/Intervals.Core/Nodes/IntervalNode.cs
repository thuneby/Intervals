using Intervals.Core.Models;

namespace Intervals.Core.Nodes
{
    internal class IntervalNode : Node
    {
        private Interval _value;

        public IntervalNode(Interval value, string expression)
        {
            _value = value;
            Expression = expression;
        }

        public override Interval GetIValue()
        {
            return _value;
        }

    }
}
