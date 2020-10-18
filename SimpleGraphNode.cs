using System;
using System.Collections.Generic;

namespace SimpleGraph
{
    public class SimpleGraphNode<T> : ISimpleGraphNode<T>
    {
        public SimpleGraphNode()
        {
            Inputs = new List<ISimpleGraphTerminal<T>>();
            Outputs = new List<ISimpleGraphTerminal<T>>();
        }

        public SimpleGraphNode(int index) : this()
        {
            Index = index;
        }

        public int Index;

        public List<ISimpleGraphTerminal<T>> Inputs { get; set; }
        public List<ISimpleGraphTerminal<T>> Outputs { get; set; }
        public T Value { get; set; }

        public virtual void Calculate()
        {
        }

        public override string ToString()
        {
            return Index.ToString();
        }
    }
}
