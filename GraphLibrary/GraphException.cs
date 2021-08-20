using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class GraphException : Exception
    {
        public GraphException(string message) : base(message) { }
    }


    public class GraphIsEmptyException : GraphException
    {
        public GraphIsEmptyException() : base("Граф не содержит вершин") { }
    }


    public class GraphOverflowException : GraphException
    {
        public GraphOverflowException() : base("Граф переполнен") { }
    }


    public class GraphAddException : GraphException
    {
        public GraphAddException() : base("Недопустимо добавление элемента в неизменяемый граф") { }
    }


    public class GraphClearException : GraphException
    {
        public GraphClearException() : base("Недопустима очистка неизменяемого графа") { }
    }


    public class GraphRemoveException : GraphException
    {
        public GraphRemoveException() : base("Недопустимо удаление элемента из неизменяемого графа") { }
    }


    public class GraphVertexNotExsistsException : GraphException
    {
        public GraphVertexNotExsistsException() : base("Попытка работы с вершиной, которой нет в графе") { }
    }


    public class GraphEdgeNotExsistsException : GraphException
    {
        public GraphEdgeNotExsistsException() : base("Попытка работы с ребром, которого нет в графе") { }
    }

    public class GraphOutOfRangeException : GraphException
    {
        public GraphOutOfRangeException() : base("Выход за допустимый диапазон") { }
    }
}
