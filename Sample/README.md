# Car Rental

- Objective: Build a system for a car rental company that tracks available cars, customers, and reservations.  
- Data Structures:
    - Queue: For managing customer reservations.
    - Linked List: To keep track of cars available for rent.
- OOP Concepts:
    - Use inheritance for different types of cars (e.g., Truck, Van).
    - Polymorphism for calculating rental fees based on car type or rental duration.


## Getting Started

1. Create a new folder called Week4c then open up a terminal/command prompt and step inside Week4c to create a new console application called **CarRental**

```shell
dotnet new console -n CarRental
```
2. Next, we also want to create a testing project so we can test the code that we build. In the terminal while still in the Week4c folder, type the following;

```shell
dotnet new xunit -n CarRental.Tests
```

3. This will create a new project specifically for testing. You should now have 2 folders inside of Week4c

```shell
Week4c
    CarRental
    CarRental.Tests
```
4. Next, we need to add a reference to the main project from the test project. Step inside the CarRental.Tests folder and run the following:
```shell
#Windows
dotnet add reference ..\CarRental\CarRental.csproj

#Mac/Linux
dotnet add reference ../CarRental/CarRental.csproj
```

5. Inside the CarRental.Tests folder, there is a file called **UnitTest1.cs**. Open this and add the following:

```c#
namespace CarRental.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //add the below Assertion:
        Assert.Equal(1, 1);
    }
}
```
6. While still inside the CarRental.Tests folder, run the following command to run the above test:

```shell
dotnet test
```

7. This will run any tests inside the folder and output something like below:

```shell
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: < 1 ms - CarRetnal.Tests.dll (net8.0)
```
8. This shows us that our test - although simple has passed. We can also get more details from the output by passing in flags like below:

```shell
dotnet test -v normal
```
9. Lets create a new folder called Models inside the CarRental.Tests folder. 
10. Create an new file called CarTests.cs and add the following:

```c#
using Xunit;
using CarRental.Models;

namespace CarRental.Tests;

public class CarTest
{
    [Fact]
    public void Car_ShouldBeIntanceOfVehicle()
    {
        Car rentalCar = CreateCarObject();
        Assert.IsType<Car>(rentalCar);
        Assert.IsAssignableFrom<Vehicle>(rentalCar);
    }

    private Car CreateCarObject() {
        return new Car("24-D-1234", "Toyota", "CH-R", 2024, "Metalic Silver", 1.6, "Petrol", 5, true, 100, true);
    }

}
```

11. If we run the **dotnet test** it will fail. The reason being, we have not created the classes. This form of testing is called Test Driven Development or TDD. You create your tests first, code second. Lets fix this be creating both Vehicle and Car classes inside the CarRental project.  

12. Open up the **CarRental** Project and add a new folder called Models. Inside the Models folder create two files - **Vehicle.cs** and **Car.cs** and copy the below into each respective class:


```c#
using System;

namespace CarRental.Models;

public class Vehicle {
    public string RegId {get;}
    public string Make {get;}
    public string Model {get;}
    public int Year {get;}
    public string Color {get;}
    public double EngineSize {get;}
    public string EngineType {get;}
    public int NoOfDoors {get;}
    public bool IsAutomatic {get;}

    public Vehicle(string reg, string make, string model, int year, string color, double engineSize, string engineType, int noOfDoors, bool isAutomatic)
    {
        this.RegId = reg;
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
        this.EngineSize = engineSize;
        this.EngineType = engineType;
        this.NoOfDoors = noOfDoors;
        this.IsAutomatic = isAutomatic;
    }

    public virtual double CalculateRentalFee(int days)
    {
        return 0; // Default fee to be overridden in derived classes
    }

    public override string ToString()
    {
        return $"{Model} (License: {RegId})";
    }
}
```

```c#
using System;

namespace CarRental.Models;
public class Car : Vehicle {

    public int TrunkCapacity {get;}

    public bool IsConvertable {get;}

    public Car(string RegId, string Make, string Model, int Year, string Color, double EngineSize, string EngineType, int NoOfDoors, bool IsAutomatic, int TrunkCapacity, bool IsConvertable) : base(RegId, Make, Model, Year, Color, EngineSize, EngineType, NoOfDoors, IsAutomatic)
    { 
        this.TrunkCapacity = TrunkCapacity;
        this.IsConvertable = IsConvertable;
    }

    public override double CalculateRentalFee(int days)
    {
        return days * 30;
    }

}
```

13. Go back to the CarRental.Tests folder and run the following again:

```shell
dotnet test
```

14. The tests should now pass. 