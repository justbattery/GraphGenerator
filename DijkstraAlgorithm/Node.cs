using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    internal class Node
    {
        public int Id { get; set; }
        public int Distance { get; set; }
        public List<Edge> Edges { get; set; }

        public Node(int id) 
        {
            Id = id;
            Distance = int.MaxValue;
            Edges = new List<Edge>();
        }
    }
}
