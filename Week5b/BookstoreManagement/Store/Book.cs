namespace BookstoreManagement.Store;
public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public double price { get; set; }
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }


    public override string ToString() {
        return title + "," + author + " €" + price;
    }
}