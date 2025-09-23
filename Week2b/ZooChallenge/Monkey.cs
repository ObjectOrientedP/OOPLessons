using System;

public class Monkey : Animal {

    public Monkey(string name, int age) : base(name, age) {}

    public override void MakeSound() {
        Console.WriteLine("The monkey screeches");
    }
}