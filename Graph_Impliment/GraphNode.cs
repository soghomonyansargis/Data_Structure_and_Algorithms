using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    public class GraphNode<T>
    {
        T value;
        List<GraphNode<T>> neighbors;
        public bool visited { get; set; }

        public GraphNode(T value)
        {
            this.value = value;
            neighbors = new List<GraphNode<T>>();
        }

        public T Value
        {
            get { return value; }
        }

        public IList<GraphNode<T>> Neighbors
        {
            get { return neighbors.AsReadOnly(); }
        }
        //Adds the given node as a neighbor for this node, 
        //true if the neighbor was added ,false otherwise
        public bool AddNeighbor(GraphNode<T> neighbor)
        {
            if (neighbors.Contains(neighbor))
            {
                return false;
            }
            else
            {
                neighbors.Add(neighbor);
                return true;
            }
        }
        //Remove the given node as a neighbor for this node, 
        //true if the neighbor was removed ,false otherwise
        public bool RemoveNeighbor(GraphNode<T> neighbor)
        {
            return neighbors.Remove(neighbor);
        }

        public bool RemoveAllNeighbors()
        {
            for (int i = 0; i <= neighbors.Count-1; i++)
            {
                neighbors.RemoveAt(i);
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("[Node value: "+value+ " Neighbors");
            for (int i = 0; i < neighbors.Count; i++)
            {
                builder.Append(neighbors[i].Value +" " );
            }
            builder.Append(" ]");
            return builder.ToString();
        }
    }
}
