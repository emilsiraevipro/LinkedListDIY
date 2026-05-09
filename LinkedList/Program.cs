
using LinkedList.Model;

namespace LinkedListDIY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedListDOIT<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            foreach (var i in linkedList)
            {
                Console.Write(i + " ");
            }
            //linkedList.Delete(1);
            Console.WriteLine();
            Console.WriteLine(linkedList.Head);
            Console.WriteLine(linkedList.Head.Next);
            Console.WriteLine(linkedList.Tail);
            Console.WriteLine(linkedList.Tail.Next);
            linkedList.Delete(5);
            linkedList.Delete(2);
            linkedList.Delete(7);
            //linkedList.Delete(7);
            //linkedList.Delete(7);
            linkedList.Delete(5);
            linkedList.Delete(2);
            linkedList.Delete(7);
            foreach (var i in linkedList)
            {
                Console.Write(i + " ");
            }
            //for (int i = 0; i < linkedList.Count; i++)
            //{
            //}
        }
    }
}
