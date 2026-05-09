using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Data in lists cell
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        private T data = default(T);
        private Item<T> next = null;
        public T Data
        {
            get { return data; }
            set
            {
                //if (value != null) data = value;
                data = value ?? throw new ArgumentNullException(nameof(value), "Аргумент не может быть null");
            }
        }
        /// <summary>
        /// Next cell
        /// </summary>
        public Item<T> Next
        {
            get { return next; }
            set
            {
                next = value;
            }
        }
        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
 