using System;
namespace SimpleGraph
{
    public interface ISimpleGraphEdge<T>
    {
        ISimpleGraphTerminal<T> From { get; set; }
        ISimpleGraphTerminal<T> To { get; set; }
    }
}
