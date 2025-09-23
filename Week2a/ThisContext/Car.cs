using System;

public class Car {

    private string make;
    private string model;
    private int year;

    public Car SetMake(string make)
    {
        this.make = make;
        return this; // Returning the current instance
    }
    public Car SetModel(string model)
    {
        this.model = model;
        return this; // Returning the current instance
    }
    public Car SetYear(int year)
    {
        this.year = year;
        return this; // Returning the current instance
    }
    public void DisplayCarInfo() {
        Console.WriteLine($"Car: {this.year} {this.make} {this.model}");
    }
}