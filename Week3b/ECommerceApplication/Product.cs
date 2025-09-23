using System;

// Define the base Product class
public abstract class Product : IProduct
{
    private string _name { get; set; }
    private double _price { get; set; }
    private double _weight { get; set; } // in kilograms

    // Constructor
    public Product(string name, double price, double weight)
    {
        _name = name;
        _price = price;
        _weight = weight;
    }

    // Default method to calculate shipping cost based on weight
    public virtual double CalculateShippingCost(double cost)
    {
        return _weight * cost;
    }

    // Default method to apply a discount to the price
    public virtual void ApplyDiscount(double discountPercentage)
    {
        _price -= (_price * discountPercentage / 100);
    }

    // Abstract method to display product details (must be implemented by derived classes)
    public virtual void DisplayDetails() {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Weight: {_weight}");
    }
}