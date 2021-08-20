using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace GraphLibrary
{
    public interface IGraph<N, L> : IEnumerable<N>
    {
        int Count { get; }
        int CountLinks { get; }
        bool IsEmpty { get; }
        IEnumerable<N> Nodes { get; }
        MyList<(N, L)> Links(N node);
        void AddNode(N node);
        void AddLink(N node1, N node2, L link);
        void Clear();
        void RemoveNode(N node);
        void RemoveLink(N node1, N node2);
        bool Contains(N node);

        N this[int index] { get;}
        int IndexOf(N node);

    }
}
