using System;

public class Lion : Animal {

    public Lion(string name, int age) : base(name, age) {}

    public override void MakeSound() {
        Console.WriteLine("The lion roars");
    }
}