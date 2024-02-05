namespace _01._Generic_Box_of_int
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in this.data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}