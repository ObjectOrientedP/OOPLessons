using System;


public class ExampleClass : IExample {

    public void DoSomething() {
        Console.WriteLine("I did something!");
    }

    public int GetValue() {
        return 1;
    }
}