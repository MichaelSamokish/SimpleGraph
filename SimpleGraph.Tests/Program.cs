using System;

namespace SimpleGraph.Tests
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var graph = new SimpleGraph<bool>();

            var node1 = new SimpleGraphNode<bool>(1);
            var Node1Input1 = new SimpleGraphTerminal<bool>(node1);
            var Node1Input2 = new SimpleGraphTerminal<bool>(node1);
            var Node1Output= new SimpleGraphTerminal<bool>(node1);
            node1.Inputs.Add(Node1Input1);
            node1.Inputs.Add(Node1Input2);
            node1.Outputs.Add(Node1Output);

            var node2 = new SimpleGraphNode<bool>(2);
            var Node2Input1 = new SimpleGraphTerminal<bool>(node2);
            var Node2Output = new SimpleGraphTerminal<bool>(node2);
            node2.Inputs.Add(Node2Input1);
            node2.Outputs.Add(Node2Output);

            var node3 = new SimpleGraphNode<bool>(3);
            var Node3Input1 = new SimpleGraphTerminal<bool>(node3);
            var Node3Output = new SimpleGraphTerminal<bool>(node3);
            node3.Inputs.Add(Node3Input1);
            node3.Outputs.Add(Node3Output);

            var node4 = new SimpleGraphNode<bool>(4);
            var Node4Output = new SimpleGraphTerminal<bool>(node4);
            node4.Outputs.Add(Node4Output);

            var node5 = new SimpleGraphNode<bool>(5);
            var Node5Output = new SimpleGraphTerminal<bool>(node5);
            node5.Outputs.Add(Node5Output);

            var node6 = new SimpleGraphNode<bool>(6);
            var Node6Input1 = new SimpleGraphTerminal<bool>(node6);
            node6.Inputs.Add(Node6Input1);

            graph.AddNode(node1);
            graph.AddNode(node2);
            graph.AddNode(node3);
            graph.AddNode(node4);
            graph.AddNode(node5);
            graph.AddNode(node6);

            graph.AddEdge(new SimpleGraphEdge<bool>(Node3Output, Node6Input1));
            graph.AddEdge(new SimpleGraphEdge<bool>(Node1Output, Node2Input1));
            graph.AddEdge(new SimpleGraphEdge<bool>(Node2Output, Node3Input1));
            graph.AddEdge(new SimpleGraphEdge<bool>(Node4Output, Node1Input1));
            graph.AddEdge(new SimpleGraphEdge<bool>(Node5Output, Node1Input2));

            graph.CalculateFromNode(node3);

            Console.ReadKey();
        }
    }
}
