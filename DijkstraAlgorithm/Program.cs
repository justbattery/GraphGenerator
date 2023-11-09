namespace DijkstraAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(8);

            graph.AddEdge(0, 1, 1);
            graph.AddEdge(0, 2, 1);
            graph.AddEdge(1, 3, 1);
            graph.AddEdge(2, 4, 1);
            graph.AddEdge(2, 5, 1);
            graph.AddEdge(3, 6, 1);
            graph.AddEdge(5, 7, 1);
            graph.AddEdge(6, 7, 1);

            graph.Print();

            graph.Dijkstra(7);
        }
    }
}