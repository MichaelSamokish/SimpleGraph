using System;
using System.Collections.Generic;
namespace SimpleGraph
{
    public interface ISimpleGraph<T>
    {
        List<ISimpleGraphNode<T>> Nodes { get; set; }
        List<ISimpleGraphEdge<T>> Edges { get; set; }
        void AddNode(ISimpleGraphNode<T> node);
        void RemoveNode(ISimpleGraphNode<T> node);
        void AddEdge(ISimpleGraphEdge<T> edge);
        void RemoveEdge(ISimpleGraphEdge<T> edge);
        void Clear();
        void Calculate();
    }
}
