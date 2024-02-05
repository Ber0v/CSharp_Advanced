namespace _01._Generic_Box_of_int
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public void Swap(List<T> list, int index1, int index2)
        {
            if (index1 >= 0 && index1 < list.Count && index2 >= 0 && index2 < list.Count)
            {
                T temp = list[index1];
                list[index1] = list[index2];
                list[index2] = temp;
            }
        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {value}";
        }
    }
}
