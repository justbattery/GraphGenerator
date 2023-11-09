using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    internal class Graph
    {
        public List<Node> Nodes { get; set; }
        public int Size { get; set; }

        public Graph(int size) 
        { 
            Nodes = new List<Node>();
            Size = size;

            for (int i = 0; i < size; i++)
            {
                Nodes.Add(new Node(i));
            }
        }

        // METODY
        public void AddEdge(int from, int to, int weight)
        {
            Node fromNode = Nodes[from];
            Node toNode = Nodes[to];

            Edge edge = new Edge(fromNode, toNode, weight);
            fromNode.Edges.Add(edge);
        }
        public void Print()
        {
            Console.WriteLine($"Graf ma {Size} wierzchołków");
            Console.WriteLine("Krawędzie i wierzchołki:");
            foreach (Node node in Nodes)
            {
                Console.WriteLine($"Node {node.Id}");
                foreach(Edge edge in node.Edges) 
                { 
                    Console.WriteLine($"Krawędź: {edge.To.Id}, {edge.Weight}");
                }
                Console.WriteLine();
            }
        }

        public void Dijkstra(int source)
        {
            Nodes[source].Distance = 0;

            var queue = new SortedSet<Node>(Comparer<Node>.Create((a, b) =>
            {
                int compare = a.Distance.CompareTo(b.Distance);

                if(compare == 0) 
                    compare = a.Id.CompareTo(b.Id);

                return compare;
            }));

            foreach (Node node in Nodes)
                queue.Add(node);

            while(queue.Count > 0)
            {
                Node node = queue.First();
                queue.Remove(node);

                foreach(Edge edge in node.Edges)
                {
                    Node neighbor = edge.To;
                    int newDistance = node.Distance + edge.Weight;

                    if(newDistance < neighbor.Distance)
                    {
                        queue.Remove(neighbor);

                        neighbor.Distance = newDistance;

                        queue.Add(neighbor);
                    }
                }
            }
            Console.WriteLine($"Najkrótsza droga z {source} do innych to: ");

            foreach (Node node in Nodes)
                Console.WriteLine($"Wierzchołek {node.Id}: {node.Distance}");
        }
    }
}
