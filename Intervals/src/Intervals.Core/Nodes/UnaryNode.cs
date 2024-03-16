using Intervals.Core.Models;

namespace Intervals.Core.Nodes
{
    public class UnaryNode : Node
    {
        private Node _argument;
        private Func<Interval, Interval> _unaryoperator;

        public UnaryNode(Node argument, Func<Interval, Interval> unaryoperator)
        {
            _argument = argument;
            _unaryoperator = unaryoperator;
            Expression = unaryoperator.Method.Name + "(" + argument.GetExpression() + ")";
        }

        public override Interval GetIValue()
        {
            var value = _argument.GetIValue();
            var result = _unaryoperator(value);
            return result;
        }
    }
}
