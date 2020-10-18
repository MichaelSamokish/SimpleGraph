using System;
namespace SimpleGraph
{
    public interface ISimpleGraphTerminal<T>
    {
        ISimpleGraphNode<T> ParentNode { get; set; }
        T Value { get; set; }
    }
}
