using BookstoreManagement.Exceptions;


namespace BookstoreManagement.Store;

public class BookStore : IBookStore
{
    private Dictionary<string, Book> books = new Dictionary<string, Book>()
    {
               
        { "1984", new Book("1984", "George Orwell", 10.99) },
        { "To Kill a Mockingbird", new Book("To Kill a Mockingbird", "Harper Lee", 8.99) },
        { "The Great Gatsby", new Book("The Great Gatsby", "F. Scott Fitzgerald", 12.99) }
         
    };

    public void AddBook(Book book)
    {
        
        if (book == null)
        {
            throw new InvalidBookException("Invalid book! It cannot be null.");
        }

        if(this.books.ContainsKey(book.title)) {
            throw new BookAlreadyExistsException($"The book {book.title} already exists!!");
        }
        
        this.books.Add(book.title, book);
        
    }

    public Book FindBook(string title)
    {
        if (title == null)
        {
            throw new InvalidBookException("Title cannot be null.");
        }

        if(this.books.TryGetValue(title, out Book book)) {
            return book;    
        } else {
            throw new BookNotFoundException($"The book {title} does not exist!");
        }

    }

    public void RemoveBook(string title)
    {
        if (title == null)
        {
            throw new InvalidBookException("Title cannot be null.");
        }

        if(!this.books.ContainsKey(title)){
            throw new BookNotFoundException($"The book {title} does not exist!");
        }

        this.books.Remove(title);
        
    }

}