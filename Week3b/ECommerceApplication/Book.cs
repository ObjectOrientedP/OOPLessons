using System;

public class Book : Product {
    private string _isbn {get; set;}
    private string _author {get; set;}
    private string _genre {get; set;}
    private int _noOfPages {get; set;}

    public Book(string name, double price, double weight, string isbn, string author, string genre, int pages) : base(name, price, weight) {
        this._isbn = isbn;
        this._author = author;
        this._genre = genre;
        this._noOfPages = pages;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Genre: {this._genre}, Pages: {this._noOfPages}, ISBN: {this._isbn}");
    }

}