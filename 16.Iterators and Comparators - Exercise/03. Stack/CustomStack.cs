using System.Collections;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] items = new T[InitialCapacity];

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (this.items.Length == this.Count)
            {
                this.Resize();
            }

            this.items[Count] = item;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T removedItem = this.items[this.Count - 1];
            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return removedItem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 4];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}
