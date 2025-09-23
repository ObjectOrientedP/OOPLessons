using System;

class BaseClass {
    public string name;

    public BaseClass(string name) {
        this.name = name;
    }

    public void Display() {
        Console.WriteLine("From the base class: Name:" + name);
    }
}