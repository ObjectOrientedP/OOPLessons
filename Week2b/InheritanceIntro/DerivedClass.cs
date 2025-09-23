using System;

class DerivedClass : BaseClass {

    public DerivedClass(string name) : base(name) {}

    public void ShowDetails() {
        Console.WriteLine("This is a derived class");
    }
}