using System;

public abstract class Animal
{
    //abstract method
    public abstract void MakeSound();
    //non-abstract
    public void Sleep() 
    {
        Console.WriteLine("Sleeping ...");
    }
}