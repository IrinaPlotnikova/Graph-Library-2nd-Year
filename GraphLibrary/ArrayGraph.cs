using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListLibrary;

namespace GraphLibrary
{
    public class ArrayGraph<N, L> : IGraph<N, L> where N : IComparable
    {
        private const int maxCount = 100;                                // максимальное число вершин
        private N[] _nodes = new N[maxCount];                            // вершины графа
        private bool[] _isFree = new bool[maxCount];                     // указывает есть ли вершина в i-м элементе _nodes
        private bool[,] _adjacencyMatrix = new bool[maxCount, maxCount]; // матрица смежности
        private L[,] _linksValues = new L[maxCount, maxCount];           // значения ребер 


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
        public ArrayGraph()
        {
            Clear();
        }


        /// <summary>
        /// Возвращает массив, содержащий вершины графа
        /// </summary>
        public IEnumerable<N> Nodes
        {
            get
            {
                N[] result = new N[Count];
                int curr = 0; // индекс, в который добавится вершина
                int i = 0;
                while (curr < Count) // пока не все вершины добавлены
                {
                    if (!_isFree[i]) // нашли вершину
                    {
                        result[curr] = _nodes[i];
                        curr++;
                    }
                }   
                return result;
            }
        }


        /// <summary>
        /// Возвращает список из вершин, в которые есть ребро из вершины node.
        /// </summary>
        public MyList<(N, L)> Links(N node)
        { 
            int idx = Index(node); // индекс вершины node в массиве _node
            if (idx == -1)
                throw new GraphVertexNotExsistsException();
            MyList<(N, L)> result = new MyList<(N, L)>();
            for (int i = 0; i < maxCount; i++) // проходим по всем вершинам графа
                if (_adjacencyMatrix[idx, i]) // если между вершинами й_node[i] и node есть ребро
                    result.Add((_nodes[i], _linksValues[idx, i]));
            return result;
        }


        /// <summary>
        /// Добавление вершины в граф.
        /// </summary>
        public void AddNode(N node)
        {
            int freeIdx = -1;
            int i = 0;
            // пока не проверили все вершины _nodes и (в индексе i нет вершины или же она не совпалает с node)
            while(i < maxCount &&(_isFree[i] || _nodes[i].CompareTo(node) != 0))
            {
                if (_isFree[i] && freeIdx == -1) // сразу запоминаем индекс, в который потом добавим вершину
                    freeIdx = i;
                i++;
            }
            if (i == maxCount)
            {
                if (Count == maxCount)
                    throw new GraphOverflowException();
                _nodes[freeIdx] = node;
                _isFree[freeIdx] = false;
                Count++;
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
            int idx1 = Index(node1);
            int idx2 = Index(node2);
            if (idx1 == -1 || idx2 == -1) // если в графе нет вершин node1 или node2
                throw new GraphVertexNotExsistsException();
           
            if (!_adjacencyMatrix[idx1, idx2])
            {
                CountLinks++;
                _adjacencyMatrix[idx1, idx2] = true;
                _linksValues[idx1, idx2] = linkValue;
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
            for (int i = 0; i < maxCount; i++)
                _isFree[i] = true;
            for (int i = 0; i < maxCount; i++)
                for (int j = 0; j < maxCount; j++)
                    _adjacencyMatrix[i, j] = false;
        }


        /// <summary>
        /// Содержится ли вершина в графе
        /// </summary>
        /// <param name="node"> искомая вершина </param>
        /// <returns> true если содержится, иначе false </returns>
        public bool Contains(N node)
        {
            int idx = Index(node);
            return idx != -1;
        }


        /// <summary>
        /// Удаление вершины из графа
        /// </summary>
        /// <param name="node"> значение удаляемой вершины</param>
        public void RemoveNode(N node)
        {
            if (Count == 0)
                throw new GraphIsEmptyException();
            int idx = Index(node);
            if (idx == -1) // если вершина не содержится в графе
                throw new GraphVertexNotExsistsException();
            _isFree[idx] = true;
            Count--;
            IsEmpty = Count != 0;
            for (int i = 0; i < maxCount; i++) // удаление всех ребер, связанных с вершиной node
            {
                if (_adjacencyMatrix[idx, i])
                {
                    _adjacencyMatrix[idx, i] = false;
                    CountLinks--;
                }
                if (_adjacencyMatrix[i, idx])
                {
                    _adjacencyMatrix[i, idx] = false;
                    CountLinks--;
                }
            }
        }


        /// <summary>
        /// Удаление ребра между вершинами
        /// </summary>
        /// <param name="node1"> вершина, из которой исходит ребро </param>
        /// <param name="node2"> вершина, в которую ведет ребро </param>
        public void RemoveLink(N node1, N node2)
        {
            int idx1 = Index(node1);
            int idx2 = Index(node2);
            if (idx1 == -1 || idx2 == -1) // если node1 или node2 отсутствуют в графе
                throw new GraphVertexNotExsistsException();
            if (!_adjacencyMatrix[idx1, idx2]) // если между вершинами нет ребра
                throw new GraphEdgeNotExsistsException();
            CountLinks--;
            _adjacencyMatrix[idx1, idx2] = false;
        }


        public N this[int index] 
        {
            get {
                if (index >= Count || index < 0) // если индекс выходит за допустимые границы
                    throw new GraphOutOfRangeException();
                int curr = -1;
                int i = -1;
                while (curr != index)
                {
                    i++;
                    while (_isFree[i]) i++;
                    curr++;
                }
                return _nodes[i];
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
            int idx = -1;
            while (i < maxCount)
            {
                if (!_isFree[i])
                {
                    idx++;
                    if (_nodes[i].CompareTo(node) == 0)
                        return idx;
                }
                i++;
            }
            return -1;
        }


        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();


        IEnumerator<N> IEnumerable<N>.GetEnumerator()
        {
            int i = 0;
            int j = -1;
            while (i < Count)
            {
                j++;
                while (_isFree[j])
                    j++;
                yield return _nodes[j];
                i++;
            }
        }


        /// <summary>
        /// Возвращает индекс вершины в массиве _nodes
        /// </summary>
        /// <param name="node"> вершина, индекс которой необходимо найти </param>
        /// <returns> -1 если вершины нет, иначе — её индекс </returns>
        private int Index(N node)
        {
            int i = 0;
            while (i < maxCount)
            {
                if (!_isFree[i] && _nodes[i].CompareTo(node) == 0)
                    return i;
                i++;
            }
            return -1;
        }
    }
}
