using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListLibrary
{
    public interface IList<N> : IEnumerable<N>, IComparable
    {
        int Count { get; }
        void Add(N node);
        int Remove(N node);
        void RemoveAt(int index);
        int CompareTo(object list);
        bool Contains(N node);
        int IndexOf(N node);
        N this[int index] { get; }
    }

    public class ListNode<N>
    {
        public N Value;
        public ListNode<N> Next;

        public ListNode(N pValue)
        {
            Value = pValue;
            Next = null;
        }
    }
}
