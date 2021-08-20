using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace GraphLibrary
{
    public class LinkedGraph<N, L> : IGraph<N, L> where N  : IComparable where L : IComparable
    {
        private int maxCount = 100;
        private MyList<N> _nodes;
        private MyList<MyList<N>> _links;
        private MyList<MyList<L>> _linksValues;


        /// <summary>
        /// Число вершин в графе.
        /// </summary>
        public int Count { get; private set; }


        /// <summary>
        /// Число ребер в графе.
        /// </summary>
        public int CountLinks { get; private set; }


        /// <summary>
        /// Пуст ли граф.
        /// </summary>
        public bool IsEmpty { get; private set; }


        /// <summary>
        /// Конструктор без аргументов. Все значения обнуляются.
        /// </summary>
        public LinkedGraph()
        {
            Clear();
        }


        /// <summary>
        /// Возвращает список, содержащий вершины графа
        /// </summary>
        public IEnumerable<N> Nodes
        {
            get => _nodes;
        }


        /// <summary>
        /// Возвращает список из вершин, в которые есть ребро из вершины node.
        /// </summary>
        public MyList<(N, L)> Links(N node)
        {
            int idx = IndexOf(node);
            if (idx == -1)
                throw new GraphVertexNotExsistsException();
            MyList<(N, L)> result = new MyList<(N, L)>();
            ListNode<N> vertex = _links[idx].head;
            ListNode<L> linkValue = _linksValues[idx].head;
            while (vertex != null)
            {
                result.Add((vertex.Value, linkValue.Value));
                vertex = vertex.Next;
                linkValue = linkValue.Next;
            }
            return result;
        }


        /// <summary>
        /// Добавление вершины в граф.
        /// </summary>
        public void AddNode(N node)
        {
            if (!Contains(node))
            {
                if (Count == maxCount)
                    throw new GraphOverflowException();
                _nodes.Add(node);
                _links.Add(new MyList<N>());
                _linksValues.Add(new MyList<L>());
                ++Count;
                IsEmpty = false;
            }
        }


        /// <summary>
        /// Добавление ребра между вершинами node1 и node2
        /// </summary>
        /// <param name="node1"> вершина, из которой исходит ребро </param>
        /// <param name="node2"> вершина, в которую ведет ребро </param>
        /// <param name="linkValue"> значение ребра </param>
        public void AddLink(N node1, N node2, L linkValue)
        {
            int i = IndexOf(node1);
            if (i == -1 || !_nodes.Contains(node2))
                throw new GraphVertexNotExsistsException();
            MyList<N> list = _links[i];
            if (!list.Contains(node2))
            {
                list.Add(node2);
                _linksValues[i].Add(linkValue);
                CountLinks++;
            }
        }


        /// <summary>
        /// очищение содержимого графа
        /// </summary>
        public void Clear()
        {
            Count = 0;
            CountLinks = 0;
            IsEmpty = true;
            _nodes = new MyList<N>();
            _links = new MyList<MyList<N>>();
            _linksValues = new MyList<MyList<L>>();
        }


        /// <summary>
        /// Содержится ли вершина в графе
        /// </summary>
        /// <param name="node"> искомая вершина </param>
        /// <returns> true если содержится, иначе false </returns>
        public bool Contains(N node) {
            return _nodes.Contains(node);
        }


        /// <summary>
        /// Удаление вершины из графа
        /// </summary>
        /// <param name="node"> значение удаляемой вершины</param>
        public void RemoveNode(N node) {
            int idx = _nodes.Remove(node);
            if (idx == -1)
                throw new GraphVertexNotExsistsException();
            Count--;
            CountLinks -= _links[idx].Count;
            _links.RemoveAt(idx);
            _linksValues.RemoveAt(idx);
           
            int i = 0;
            foreach (MyList<N> list in _links)
            {
                int deleteIdx = list.Remove(node);
                if (deleteIdx != -1)
                {
                    _linksValues[i].RemoveAt(deleteIdx);
                    CountLinks--;
                }
                i++;
            }
            IsEmpty = Count != 0;
        }


        /// <summary>
        /// Удаление ребра между вершинами
        /// </summary>
        /// <param name="node1"> вершина, из которой исходит ребро </param>
        /// <param name="node2"> вершина, в которую ведет ребро </param>
        public void RemoveLink(N node1, N node2)
        {
            int idx1 = IndexOf(node1);
            if (idx1 == -1)
                throw new GraphVertexNotExsistsException();
            int idx2 = _links[idx1].Remove(node2);
            if (idx2 == -1)
                throw new GraphEdgeNotExsistsException();
            _linksValues[idx1].RemoveAt(idx2);
            CountLinks--;
        }


        public N this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new GraphOverflowException();
                return _nodes[index];
            }
        }


        /// <summary>
        /// Возвращает порядковый номер вершины
        /// </summary>
        /// <param name="node"> вершина, порядковый номер которой необходимо найти </param>
        /// <returns> -1 если вершины нет, иначе — её номер</returns>
        public int IndexOf(N node)
        {
            int i = 0;
            foreach(N n in _nodes)
            {
                if (node.CompareTo(n) == 0)
                    return i;
                i++;
            }

            return (i == Count) ? -1 : i;
        }


        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();


        IEnumerator<N> IEnumerable<N>.GetEnumerator()
        {
            foreach (N node in _nodes)
                yield return node;
        }


    }
}
