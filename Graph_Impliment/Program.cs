using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Graph1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = BuildGraph();

            foreach (var item in Search("dfs", graph, graph.Find(42)))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static Graph<int> BuildGraph()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(1);
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(7);
            graph.AddNode(10);
            graph.AddNode(11);
            graph.AddNode(12);
            graph.AddNode(42);

            graph.AddEdge(1, 5);
            graph.AddEdge(4, 11);
            graph.AddEdge(4, 42);
            graph.AddEdge(5, 11);
            graph.AddEdge(5, 12);
            graph.AddEdge(5, 42);
            graph.AddEdge(7, 10);
            graph.AddEdge(7, 11);
            graph.AddEdge(10, 11);
            graph.AddEdge(11, 42);
            graph.AddEdge(12, 42);
            return graph;
        }

        static void MakeUnVisited<T>(Graph<T> graph)//unmark all vertexes in graph
        {
            foreach (var node in graph.Nodes)
            {
               node.visited = false;
            }
        }
        static IList<T> BFS<T>(Graph<T> graph, GraphNode<T> start)
        {
            Console.WriteLine("Search type is BFS");
            MakeUnVisited(graph);// unmark all vertexes
            List<T> result = new List<T>(); 
            Queue<GraphNode<T>> queue = new Queue<GraphNode<T>>();
            start.visited = true;
            queue.Enqueue(start);
            GraphNode<T> n;
            while (queue.Count != 0)
            {
                n = queue.Dequeue();
                result.Add(n.Value);
                foreach (var node in n.Neighbors)
                {
                    if (!node.visited)
                    {
                        node.visited = true;
                        queue.Enqueue(node);
                    }
                } 
            }
            return result;
        }
        static IList<T> DFS<T>(Graph<T> graph, GraphNode<T> start)//no recursiv
        {
            Console.WriteLine("Search type is DFS");
            MakeUnVisited(graph);//unmark all vertexes
            List<T> result = new List<T>();
            Stack<GraphNode<T>> stack = new Stack<GraphNode<T>>();
           
            stack.Push(start);
            start.visited = true;
            GraphNode<T> n;
            while (stack.Count != 0)
            {
                n = stack.Pop();
                result.Add(n.Value);
                foreach (var node in n.Neighbors)
                {
                    if (!node.visited)
                    { 
                        stack.Push(node);
                        node.visited = true;
                    }
                }
            }
            return result;
        }
        //--------------------------------------------------------------
        static List<T> DFSRecursiv<T>(GraphNode<T> start)
        {
            List<T> result = new List<T>();
            start.visited = true;
            result.Add(start.Value);
            foreach (var node in start.Neighbors)
            {
                if (!node.visited)
                {
                    Console.WriteLine(node.Value);
                    node.visited = true;
                    result.Add(node.Value);
                    DFSRecursiv( node);  
                }
            } 
            return result;
        }
        //--------------------------------------------------------------
        public static IList<T> Search<T>(string type, Graph<T> graph, GraphNode<T> start)
        {
            if (type.ToUpper()=="BFS")
            {
               return BFS(graph, start);
            }
            else if (type.ToUpper() == "DFS")
            {
                return DFS(graph, start);
            }
            return null;
        }
        //--------------------------------------------------------------      
    }
}
