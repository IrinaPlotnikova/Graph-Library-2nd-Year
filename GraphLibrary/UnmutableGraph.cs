using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace GraphLibrary
{
    class UnmutableGraph<N, L> : IGraph<N, L> where N : IComparable<N>
    {
        IGraph<N, L> _graph;

        public UnmutableGraph(IGraph<N, L> graph) : base()
        {
            _graph = graph;
        }

        public int Count { get => _graph.Count; }

        public int CountLinks { get => _graph.CountLinks; }
        public bool IsEmpty { get => _graph.IsEmpty; }
        public IEnumerable<N> Nodes { 
            get => _graph.Nodes;
        }
        public MyList<(N, L)> Links(N node) => _graph.Links(node);

        public void AddNode(N node) => throw new GraphAddException();
        

        public void AddLink(N node1, N node2, L linkValue) => throw new GraphAddException();

        public void Clear() => throw new GraphClearException();

        public bool Contains(N node) => _graph.Contains(node);

        public void RemoveNode(N node) => throw new GraphRemoveException();
        public void RemoveLink(N node1, N node2) => throw new GraphRemoveException();

        public N this[int index] => _graph[index];

        public int IndexOf(N node) => _graph.IndexOf(node);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<N> IEnumerable<N>.GetEnumerator()
        {
            int i = 0;
            while (i < Count)
            {
                yield return _graph.Nodes.ElementAt(i);
                i++;
            }
        }

    }
}
