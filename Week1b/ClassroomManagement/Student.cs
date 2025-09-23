using System;

public class Student {

    //attributes
    public string Name { get; set; }
    public int Grade { get; set; }
    //constructor
    public Student(string name, int grade) {
        Name = name;
        Grade = grade;
    }
    //methods
    public void PrintDetails() {
        Console.WriteLine($"Student: {Name}, Grade: {Grade}");
    }
}