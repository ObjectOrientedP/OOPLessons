using System;

public class Cat : Animal
{
    public Cat(){}

    public override void MakeSound() {
        Console.WriteLine("The cat goes meow ...");
    }
}