using System;
namespace SimpleGraph
{
    public class SimpleGraphEdge<T> : ISimpleGraphEdge<T>
    {
        public SimpleGraphEdge()
        {
        }

        public SimpleGraphEdge(ISimpleGraphTerminal<T> from, ISimpleGraphTerminal<T> to)
        {
            From = from;
            To = to;
        }

        public ISimpleGraphTerminal<T> From { get; set; }
        public ISimpleGraphTerminal<T> To { get; set; }
    }
}
