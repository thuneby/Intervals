using Intervals.Core.Models;

namespace Intervals.Core.Nodes
{
    public abstract class Node
    {
        internal string Expression { get; set; } = "";
        public string GetExpression()
        {
            return Expression;
        }
        public abstract Interval GetIValue();

    }
}
