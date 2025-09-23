using System;

public class Elephant : Animal {

    public Elephant(string name, int age) : base(name, age) {}

    public override void MakeSound() {
        Console.WriteLine("The elephant trumpets");
    }
}