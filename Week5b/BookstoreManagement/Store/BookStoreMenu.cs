using BookstoreManagement.Exceptions;


namespace BookstoreManagement.Store;
public class BookStoreMenu
{
    private BookStore bookStore = new BookStore();
    public void InitMenu()
    {

        int choice = 0;

        do
        {
            Console.WriteLine("\nWelcome to the Bookstore Inventory:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Find Book");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        this.AddNewBook();
                        break;
                    case 2:
                        this.FindBookByTitle();
                        break;
                    case 3:
                        this.RemoveBookByTitle();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Bookstore! Please wait ...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("Unknown Option: " + ex.Message);

            }

        } while (choice != 4);
    }

    private void AddNewBook()
    {
        string title = GetBookTitle();
        string author = GetAuthor();
        double price = GetPrice();

        try
        {
            bookStore.AddBook(new Book(title, author, price));
        }
        catch (InvalidBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (BookAlreadyExistsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void FindBookByTitle()
    {
        string title = GetBookTitle();

        try
        {
            Book book = bookStore.FindBook(title);
            Console.WriteLine(book.ToString());
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private void RemoveBookByTitle()
    {
        string title = GetBookTitle();

        try
        {
            this.bookStore.RemoveBook(title);
            Console.WriteLine($"The book {title} has been removed.");
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine($"The book {title} does not exist!");
        }
    }

    private string GetBookTitle() {
        Console.WriteLine("Enter book Name:");
        string title = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Book name cannot be empty. Please enter a valid book name:");
            title = Console.ReadLine();
        }

        return title;        
    }

    private string GetAuthor() {
        Console.WriteLine("Enter book Author:");
        string author = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(author)) 
        {
            Console.WriteLine("Author name cannot be empty. Please enter a valid author name:");
            author = Console.ReadLine();
        }
        return author;
    }

    private double GetPrice() {
        Console.WriteLine("Enter Price:");
        string priceInput = Console.ReadLine();
        double price;
        while (!double.TryParse(priceInput, out price) || price < 0) // Ensure valid positive number
        {
            Console.WriteLine("Invalid price. Please enter a valid positive number for price:");
            priceInput = Console.ReadLine();
        }
        return price;
    }

}