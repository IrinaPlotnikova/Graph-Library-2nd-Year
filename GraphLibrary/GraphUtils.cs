using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace GraphLibrary
{
    public delegate IGraph<N, L> GraphConstructorDelegate<N, L>();
    public delegate bool CheckDelegate<N, L>(N node);
    public delegate N ActionDelegate<N, L>(N node);
    public class GraphUtils
    {
        
        public static  IGraph<N, L> ArrayGraphConstructor<N, L>() where N : IComparable
        {
            return new ArrayGraph<N, L>();
        }
        public static IGraph<N, L> LinkedGraphConstructor<N, L>() where N : IComparable where L : IComparable
        {
            return new LinkedGraph<N, L>();
        }
        
        public static bool Exists<N, L>(IGraph<N, L> graph, CheckDelegate<N, L> check)
        {
            foreach (N node in graph)
                if (check(node))
                    return true;
            return false;
        }
        public static IGraph<N, L> FindAll<N, L>(IGraph<N, L> graph, CheckDelegate<N, L> check, 
                                                 GraphConstructorDelegate<N, L> constructor) {
            IGraph<N, L> result = constructor();

            foreach (N node in graph)
                if (check(node))
                    result.AddNode(node);
            return result;
        }
        public static void ForEach<N, L>(IGraph<N, L> graph, ActionDelegate<N, L> action) where N : IComparable<N>
        {
          
            for (int i = 0; i < graph.Count; i++)
                action(graph[i]);
        }
        public static bool CheckForAll<N, L>(IGraph<N, L> graph, CheckDelegate<N, L> check)
        {
            int n = graph.Count;
            int i = 0;
            while (i < n && check(graph[i]))
                i++;

            return i == n;
        }

        private static void DFS<N, L>(ref IGraph<N, L> graph, ref HashSet<N> visited, ref MyList<(N, N, L)> result, N node)
        {
            visited.Add(node);
            foreach ((N, L) link in graph.Links(node))
                if (!visited.Contains(link.Item1))
                {
                    result.Add((node, link.Item1, link.Item2));
                    DFS(ref graph, ref visited, ref result, link.Item1);
                } 
        }

        public static MyList<(N, N, L)> DFS<N, L>(IGraph<N, L> graph, N node)
        {
            if (!graph.Contains(node))
                throw new Exception("");
            HashSet<N> visited = new HashSet<N>();
            MyList<(N, N, L)> result = new MyList<(N, N, L)>();
            if (graph.Count != 0)
                DFS(ref graph, ref visited, ref result, node);
            return result;
        }

        public static MyList<(N, N, L)> BFS<N, L>(IGraph<N, L> graph, N node)
        {
            if (!graph.Contains(node))
                throw new Exception("");
            HashSet<N> visited = new HashSet<N>();
            Queue<N> queue = new Queue<N>();
            visited.Add(node);
            queue.Enqueue(node);
            MyList<(N, N, L)> result = new MyList<(N, N, L)>();
            while(queue.Count != 0)
            {
                N tmp = queue.Dequeue();
                foreach ((N, L) link in graph.Links(tmp))
                    if (!visited.Contains(link.Item1))
                    {
                        visited.Add(link.Item1);
                        queue.Enqueue(link.Item1);
                        result.Add((tmp, link.Item1, link.Item2));
                    }
            }
            return result;
        }

        private static void DFSIsAcyclic<N, L>(ref IGraph<N, L> graph, ref HashSet<N> visited, ref HashSet<N> currVisited, N node, ref bool flag)
        {
            if (currVisited.Contains(node))
                flag = false;
            else if (!visited.Contains(node))
            {
                currVisited.Add(node);
                foreach ((N, L) link in graph.Links(node))
                    DFSIsAcyclic(ref graph, ref visited, ref currVisited, link.Item1, ref flag);
            }
           
        }

        public static bool IsAcyclic<N, L>(IGraph<N, L> graph)
        {
            HashSet<N> visited = new HashSet<N>();
            foreach (N node in graph)
            {
                if (!visited.Contains(node))
                {
                    HashSet<N> currVisited = new HashSet<N>();
                    bool flag = true;
                    DFSIsAcyclic<N, L>(ref graph, ref visited, ref currVisited, node, ref flag);
                    if (!flag)
                        return false;
                    visited.UnionWith(currVisited);
                }
            }
            return true;
        }



       
    }
}
