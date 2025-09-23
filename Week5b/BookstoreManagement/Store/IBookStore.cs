namespace BookstoreManagement.Store;
public interface IBookStore
{
    void AddBook(Book book);

    Book FindBook(string title);

    void RemoveBook(string title);
}