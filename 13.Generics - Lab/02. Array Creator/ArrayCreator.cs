namespace GenericArrayCreator
{
    public class ArrayCreator
    {

        public static T[] Create<T>(int length, T item)
        {
            T[] arrey = new T[length];

            for (int i = 0; i < length; i++)
            {
                arrey[i] = item;
            }
            return arrey;
        }
    }

}
