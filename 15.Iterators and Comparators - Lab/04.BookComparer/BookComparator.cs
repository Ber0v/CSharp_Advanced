namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book book1, Book book2)
        {
            if (book1.Title.CompareTo(book2.Title) > 0)
            {
                return 1;
            }
            else if (book1.Title.CompareTo(book2.Title) < 0)
            {
                return -1;
            }
            else
            {
                return book2.Year.CompareTo(book1.Year);
            }
        }
    }
}
