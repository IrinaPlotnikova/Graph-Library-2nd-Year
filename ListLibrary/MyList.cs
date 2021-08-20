using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListLibrary
{
    public class MyList<N> : IList<N> where N : IComparable
    {

        public ListNode<N> head;
        private ListNode<N> tail;

        public MyList()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public int Count { get; private set; }

        // добавление элемента в список
        public void Add(N pValue)
        {
            ListNode<N> new_node = new ListNode<N>(pValue);
            if (Count == 0)
                head = new_node;
            else
                tail.Next = new_node;
            tail = new_node;
            Count++;
        }

        // удаление элемента из списка, возвращает индекс удаленного значения
        public int Remove(N deleteValue)
        {
            if (Count == 0)
                return -1;

            if (head.Value.CompareTo(deleteValue) == 0)
            {
                head = head.Next;
                Count--;
                if (Count == 0)
                    tail = null;
                return 0;
            }

            int result = 1;
            ListNode<N> tmp = head;
            while (tmp.Next != null && tmp.Next.Value.CompareTo(deleteValue) != 0)
            {
                tmp = tmp.Next;
                result++;
            }

            if (tmp.Next != null)
            {
                tmp.Next = tmp.Next.Next;
                Count--;
                if (tmp.Next == null)
                    tail = tmp;
            }
            else
                result = -1;

            return result;
        }

        // удаление элемента в позиции index
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count)
                throw new Exception("Выход за границы списка");
            ListNode<N> tmp = head;

            for (int i = 0; i < index - 1; i++)
                tmp = tmp.Next;

            if (index == 0)
                head = head.Next;
            else
                tmp.Next = tmp.Next.Next;

            if (tmp == null)
                tail = null;
            else if (tmp.Next == null)
                tail = tmp;
            Count--;
        }

        public N this[int index] {
            get
            {
                if (index < 0 || index > Count)
                    throw new Exception("Выход за границы списка");
                ListNode<N> tmp = head;
                for (int i = 0; i < index; i++)
                    tmp = tmp.Next;
                return tmp.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
        IEnumerator<N> IEnumerable<N>.GetEnumerator()
        {
            ListNode<N> tmp = head;
            while (tmp != null)
            {
                yield return tmp.Value;
                tmp = tmp.Next;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null && head != null || !GetType().Equals(obj.GetType()))
                return -1;
            IList<N> list = (IList<N>)(obj);
            if (Count != list.Count)
                return 1;
            ListNode<N> tmp = head;
            int i = 0;
            while (head != null && tmp.Value.CompareTo(list[i]) == 0)
            {
                tmp = tmp.Next;
                i++;
            }
            return (i == Count) ? 0 : 1;
        }


        // проверка наличия элемента в списке
        public bool Contains(N node)
        {
            ListNode<N> tmp = head;
            while (tmp != null && tmp.Value.CompareTo(node) != 0)
                tmp = tmp.Next;
            return tmp != null;
        }

        // индекс элемента node
        public int IndexOf(N node)
        {
            ListNode<N> tmp = head;
            int i = 0;
            while(tmp != null && tmp.Value.CompareTo(node) != 0)
            {
                tmp = tmp.Next;
                i++;
            }
            return (i == Count) ? -1 : i;
        }

    }
}
