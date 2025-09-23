using System;

public class Animal {
    private string Name;
    private int Age;

    public Animal(string name, int age) {
        this.Name = name;
        this.Age = age;
    }

    public virtual void MakeSound() {
        Console.WriteLine("Animal makes a sound!");
    }
    public void Eat() {
        Console.WriteLine("The animal is eating.");
    }

    public void Sleep() {
        Console.WriteLine("The animal is sleeping.");
    }
}