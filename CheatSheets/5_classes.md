### C# Class Cheat Sheet

#### 1. **Defining a Class:**
```csharp
public class MyClass {
    // Fields
    public string Name;

    // Constructor
    public MyClass(string name) {
        Name = name;
    }

    // Method
    public void DisplayName() {
        Console.WriteLine(Name);
    }
}
```

#### 2. **Creating an Object:**
```csharp
MyClass obj = new MyClass("Alice");
obj.DisplayName();  // Output: Alice
```

#### 3. **Properties:**
```csharp
public class Person {
    private string _name;

    // Property
    public string Name {
        get { return _name; }
        set { _name = value; }
    }
}

Person p = new Person();
p.Name = "Bob";
Console.WriteLine(p.Name);  // Output: Bob
```

#### 4. **Constructors:**
```csharp
public class Car {
    public string Model;
    public int Year;

    // Parameterless constructor
    public Car() {
        Model = "Unknown";
        Year = 2000;
    }

    // Parameterized constructor
    public Car(string model, int year) {
        Model = model;
        Year = year;
    }
}

Car car1 = new Car();  // Uses parameterless constructor
Car car2 = new Car("Toyota", 2024);  // Uses parameterized constructor
```

#### 5. **Methods:**
```csharp
public class Calculator {
    // Method with return type
    public int Add(int a, int b) {
        return a + b;
    }

    // Method without return type
    public void PrintSum(int a, int b) {
        Console.WriteLine(a + b);
    }
}

Calculator calc = new Calculator();
int sum = calc.Add(5, 10);
calc.PrintSum(5, 10);  // Output: 15
```

#### 6. **Inheritance:**
```csharp
public class Animal {
    public void Eat() {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Barking...");
    }
}

Dog myDog = new Dog();
myDog.Eat();  // Inherited method
myDog.Bark(); // Derived class method
```

#### 7. **Encapsulation:**
```csharp
public class BankAccount {
    private double balance;

    public void Deposit(double amount) {
        if (amount > 0) {
            balance += amount;
        }
    }

    public double GetBalance() {
        return balance;
    }
}

BankAccount account = new BankAccount();
account.Deposit(100);
Console.WriteLine(account.GetBalance());  // Output: 100
```

#### 8. **Static Members:**
```csharp
public class MathHelper {
    public static double Pi = 3.14159;

    public static double Square(double number) {
        return number * number;
    }
}

double area = MathHelper.Square(5);
Console.WriteLine(MathHelper.Pi);  // Output: 3.14159
```

#### 9. **Abstract Classes:**
```csharp
public abstract class Shape {
    public abstract double GetArea();
}

public class Rectangle : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double GetArea() {
        return Width * Height;
    }
}

Rectangle rect = new Rectangle { Width = 5, Height = 10 };
Console.WriteLine(rect.GetArea());  // Output: 50
```

#### 10. **Interfaces:**
```csharp
public interface IDrawable {
    void Draw();
}

public class Circle : IDrawable {
    public void Draw() {
        Console.WriteLine("Drawing a circle");
    }
}

IDrawable drawable = new Circle();
drawable.Draw();  // Output: Drawing a circle
```

#### 11. **Inheritance and Base Class Access:**
```csharp
public class BaseClass {
    public void BaseMethod() {
        Console.WriteLine("Base method");
    }
}

public class DerivedClass : BaseClass {
    public void DerivedMethod() {
        Console.WriteLine("Derived method");
    }
}

DerivedClass obj = new DerivedClass();
obj.BaseMethod();  // Access base class method
obj.DerivedMethod();  // Access derived class method
```

#### 12. **Polymorphism:**
```csharp
public class BaseClass {
    public virtual void Show() {
        Console.WriteLine("Base class");
    }
}

public class DerivedClass : BaseClass {
    public override void Show() {
        Console.WriteLine("Derived class");
    }
}

BaseClass obj = new DerivedClass();
obj.Show();  // Output: Derived class
```

This cheat sheet covers the key concepts and usage of classes in C#. If you need more details on any specific topic, feel free to ask!