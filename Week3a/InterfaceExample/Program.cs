using System;


public class Program
{
    public static void Main(string[] args) {        
        IMoveable car = new Car();
        IMoveable bike = new Bicycle();
        IMoveable[] vehicles = { car, bike };

        foreach(IMoveable vehicle in vehicles) {
            vehicle.Move();
        }

    }
}

