using System;
using System.Collections.Generic;

public class Classroom {
    public List<Student> Students { get; set; } 

    public Classroom() {
        Students = new List<Student>();
    }

    public void AddStudent(Student student) {
        Students.Add(student);
        Console.WriteLine($"Added {student.Name} to the classroom.");
    }

    public void RemoveStudent(string name) {
        Student studentToRemove = Students.Find(x => x.Name == name);
        if(studentToRemove != null) {
            Students.Remove(studentToRemove);
            Console.WriteLine($"Removed {name} from the classroom.");
        } else {
            Console.WriteLine($"{name} is not in this classroom.");
        }
    }


    public void ListStudents() {
        foreach(Student student in Students) {
            student.PrintDetails();
        }
    }
}