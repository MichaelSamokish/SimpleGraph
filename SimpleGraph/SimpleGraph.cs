using System.Collections.Generic;
using System.Linq;

namespace SimpleGraph
{
    public class SimpleGraph<T> : ISimpleGraph<T>
    {
        public List<ISimpleGraphNode<T>> Nodes { get; set; }
        public List<ISimpleGraphEdge<T>> Edges { get; set; }

        private List<ISimpleGraphNode<T>> CalculationOrder { get; set; }

        public SimpleGraph()
        {
            Nodes = new List<ISimpleGraphNode<T>>();
            Edges = new List<ISimpleGraphEdge<T>>();
        }

        public void AddEdge(ISimpleGraphEdge<T> edge)
        {
            Edges.Add(edge);
            TopologicalSort();
        }

        public void AddNode(ISimpleGraphNode<T> node)
        {
            Nodes.Add(node);
            TopologicalSort();
        }

        public void Clear()
        {
            if(Nodes != null)
            {
                Nodes.Clear();
            }
            if(Edges != null)
            {
                Nodes.Clear();
            }
        }

        public void RemoveEdge(ISimpleGraphEdge<T> edge)
        {
            Edges.Remove(edge);
        }

        public void RemoveNode(ISimpleGraphNode<T> node)
        {
            Nodes.Remove(node);
        }

        public void Calculate()
        {
            if (!CanCalculate())
                return;

            foreach (var node in CalculationOrder)
            {
                node.Calculate();
            }
        }

        public void CalculateFromNode(ISimpleGraphNode<T> node)
        {
            if (!CanCalculate())
                return;
            var nodeIndex = CalculationOrder.IndexOf(node);
            var order = CalculationOrder.GetRange(nodeIndex, CalculationOrder.Count - nodeIndex);
            foreach(var orderNode in order)
            {
                orderNode.Calculate();
            }
        }

        private bool CanCalculate()
        {
            if (CalculationOrder == null)
            {
                TopologicalSort();
                if (CalculationOrder == null)
                    return false;
            }

            return true;
        }

        private void DepthFirstSearch(ISimpleGraphNode<T> node, Dictionary<ISimpleGraphNode<T>, bool> visited, Stack<ISimpleGraphNode<T>> stack)
        {
            visited[node] = true;
            foreach (var terminal in node.Outputs)
            {
                var nextNodeEdge = Edges.FirstOrDefault(e=>e.From == terminal);
                if (nextNodeEdge == null)
                    continue;
                var nextNode = nextNodeEdge.To.ParentNode;
                if(!visited[nextNode])
                {
                    DepthFirstSearch(nextNode, visited, stack);
                }
            }

            stack.Push(node);
        }

        private void TopologicalSort()
        {
            if (Nodes == null)
                return;

            var stack = new Stack<ISimpleGraphNode<T>>();
            Dictionary<ISimpleGraphNode<T>, bool> visited = new Dictionary<ISimpleGraphNode<T>, bool>();
            foreach(var node in Nodes)
            {
                visited.Add(node, false);
            }

            foreach(var node in Nodes)
            {
                if(!visited[node])
                {
                    DepthFirstSearch(node, visited, stack);
                }
            }

            CalculationOrder = stack.ToList();
            return;
        }
    }
}
