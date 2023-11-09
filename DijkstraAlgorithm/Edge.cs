﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    internal class Edge
    {
        public Node From {  get; set; }
        public Node To { get; set; }
        public int Weight {  get; set; }

        public Edge(Node from, Node to, int weight) 
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }
}
