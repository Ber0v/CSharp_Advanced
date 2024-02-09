using System.Collections;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> values)
        {
            this.items = values;
        }

        public bool Move()
        {
            if (this.index < this.items.Count - 1)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.index < this.items.Count - 1;
        }

        public void Print()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(this.items[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
