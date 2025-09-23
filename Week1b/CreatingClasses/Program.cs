using System;

class Program {

    static void Main(string[] args) {
        Person p1 = new Person("Andy Fitzgerald", 33, "Somewhere, Villa 2");
        p1.PrintDetails();
        p1.CalculateBirthYear();

        Car car1 = new Car("Ford", "Focus", 2024);
        car1.PrintCarDetails();
    }

}