namespace Algorithm
{
    public class queue<T>
    {
        private List<T> data = [];

        public void Add(T record)
        {
            data.Insert(0, record);
        }

        public T Remove()
        {
            var item = data[^1];
            data.RemoveAt(data.Count - 1);
            return item;
        }

        public T Peek()
        {
            return data[^1];
        }

        public void Display()
        {
            Console.WriteLine(string.Join(", ", data));
        }

        /*
         * 
            var q = new queue<int>();
        q.Add(1);
        q.Add(2);
        q.Add(3);
        q.Remove();
        q.Display();
         */
    }
}
