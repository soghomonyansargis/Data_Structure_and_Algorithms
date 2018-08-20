using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    public class Graph<T>
    {
        List<GraphNode<T>> nodes = new List<GraphNode<T>>();
        public Graph()
        {
            
        }
        public int Count
        {
            get { return nodes.Count; }
        }

        public IList<GraphNode<T>> Nodes
        {
            get { return nodes.AsReadOnly(); }
        }

        public void Clear()
        {
            //remove all the neighnors from the each node
            foreach (var node in nodes)
            {
                node.RemoveAllNeighbors();
            }
            //remove all the nodes from the graph
            for (int i = nodes.Count-1; i >=0; i--)
            {
                nodes.RemoveAt(i);
            }
        }
        //if a node with the same value is in the graph, the value is not added and the method returns false, else true
        public bool AddNode(T value)
        {
            if (Find(value) !=null)
            {
                return false;
            }
            else
            {
                nodes.Add(new GraphNode<T>(value));
                return true;
            }
            
        }

        public bool AddEdge(T value1,T value2)
        {
            GraphNode<T> node1 = Find(value1);
            GraphNode<T> node2 = Find(value2);
            if (node1 == null || node2==null)
            {
                return false;
            }
            else if (node1.Neighbors.Contains(node2))
            {
                //edge already exists
                return false;
            }
            else
            {
                //andirected graph, so add as Neighbors to each other
                node1.AddNeighbor(node2);
                node2.AddNeighbor(node1);
                return true;
            }
        }
        public bool RemoveNode(T value)
        {
            GraphNode<T> removeNode = Find(value);
            if (removeNode == null)
            {
                return false;
            }
            else
            {
                //need to remove as neighor for all nodes in graph
                nodes.Remove(removeNode);
                foreach (var node in nodes)
                {
                    node.RemoveNeighbor(removeNode);
                }
                return true;
            }
        }

        public bool RemoveEdge(T value1, T value2)
        {
            GraphNode<T> node1 = Find(value1);
            GraphNode<T> node2 = Find(value2);
            if (node1 == null || node2 == null)
            {
                return false;
            }
            else if (!node1.Neighbors.Contains(node2))
            {
                //edge does not exists
                return false;
            }
            else
            {
                //andirected graph, so remove as Neighbors to each other
                node1.RemoveNeighbor(node2);
                node2.RemoveNeighbor(node1);
                return true;
            }
        }

        //finds the graph node with the given value
        //return graph or null if not found
        public GraphNode<T> Find(T value)
        {
            foreach (var node in nodes)
            {
                if (node.Value.Equals(value))
                {
                    return node;
                }      
            }
            return null;
        }
        //return comma- separated string of nodes
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < Count; i++)
            {
                builder.Append(nodes[i].ToString());
                if (i<Count-1)
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }
    }
}
