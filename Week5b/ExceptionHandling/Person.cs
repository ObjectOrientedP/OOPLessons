

public class Person {
    public string name {get; set;}

    public int age {get; set;}  

    public Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public void CheckAge(int age) {
        if(age < 18) {
            throw new CustomException("You are way too young!!");
        }
    }
}