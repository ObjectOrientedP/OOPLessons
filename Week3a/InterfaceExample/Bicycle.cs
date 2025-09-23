using System;

public class Bicycle : IMoveable 
{
    public Bicycle(){}

    public void Move() {
        Console.WriteLine("The bicycle is moving ...");
    }
}