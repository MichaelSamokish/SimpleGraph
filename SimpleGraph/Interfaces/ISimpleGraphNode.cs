using System;
using System.Collections.Generic;

namespace SimpleGraph
{
    public interface ISimpleGraphNode<T>
    {
        List<ISimpleGraphTerminal<T>> Inputs { get; set; }
        List<ISimpleGraphTerminal<T>> Outputs { get; set; }
        T Value { get; set; }
        void Calculate();
    }
}
