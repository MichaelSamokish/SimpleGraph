using System;
namespace SimpleGraph
{
    public class SimpleGraphTerminal<T> : ISimpleGraphTerminal<T>
    {
        public SimpleGraphTerminal()
        {
        }

        public SimpleGraphTerminal(ISimpleGraphNode<T> parentNode)
        {
            ParentNode = parentNode;
        }

        public ISimpleGraphNode<T> ParentNode { get; set; }
        public T Value { get; set; }
    }
}
