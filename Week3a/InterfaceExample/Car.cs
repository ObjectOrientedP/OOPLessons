using System;

public class Car : IMoveable 
{
    public Car(){}

    public void Move() {
        Console.WriteLine("The car is moving ...");
    }
}