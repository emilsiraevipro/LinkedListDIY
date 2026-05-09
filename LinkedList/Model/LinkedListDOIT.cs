using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Model
{
    /// <summary>
    /// Список LinkedList
    /// </summary>
    public class LinkedListDOIT<T> : IEnumerable
    {
        /// <summary>
        /// Перый элемент списка
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Amount of elements
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// create empry list
        /// </summary>
        public LinkedListDOIT()
        {
            Clear();
        }

        /// <summary>
        /// create list with data
        /// </summary>
        /// <param name="data"></param>
        public LinkedListDOIT(T data)
        {
            SetHeadAndTail(data);
        }
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while(current != null)
                if (current.Data.Equals(target))
                {
                    var item = new Item<T>(data);
                    item.Next = current.Next;
                    current.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
            else
            {
                //Нужно для себя решить, если список пустой
                //то либо не добавлять ничего, либо вставить данные
            }
        }
        
        /// <summary>
        /// add data to end of list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
            /*if (Head == null) Head = new Ite m<T>(data);
            Tail = new Item<T>(data);
            Count += 1;*/
        }
        /// <summary>
        /// delete first element of list
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                    }
                    Tail = previous;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Add Head
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
            //if (Head != null)
            //{ 
            //    Head.Next = Head;
            //    Head.Data = data;
            //    return;
            //} Head = new Item<T>(data); return;


        }
        /// <summary>
        /// clear linkedlist
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// get enureator of each element in list
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            return "Linked List" + Count + "элементов";
        }
    }
}
