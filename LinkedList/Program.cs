using LinkedList.Model;

namespace LinkedListDIY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedListDOIT<int>();
            list.Add(1);
            list.Add(5);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(1, 2);
            list.InsertAfter(1, 2);
            list.InsertAfter(1, 2);
            list.InsertAfter(1, 2);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
