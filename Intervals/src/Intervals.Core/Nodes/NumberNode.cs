using Intervals.Core.Models;

namespace Intervals.Core.Nodes
{
    public class NumberNode : Node
    {
        private float _value;

        public NumberNode(float value, string expression)
        {
            _value = value;
            Expression = expression;
        }

        public override Interval GetIValue()
        {
            return new Interval(_value, _value);
        }

    }
}
