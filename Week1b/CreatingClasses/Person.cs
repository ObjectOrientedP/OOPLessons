using System;

public class Person {
    public string Name {get; set;}
    public int Age {get; set;}
    public string Address {get; set;}

    public Person(string name, int age, string address) {
        Name = name;
        Age = age;
        Address = address;
    }

    public void PrintDetails() {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }

    public void CalculateBirthYear() {
        int currentYear = DateTime.Now.Year;
        int birthYear = currentYear - Age;
        Console.WriteLine($"{Name} was born in the year {birthYear}");
    }

}

