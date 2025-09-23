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

    [Fact]
    public void Car_ShouldBeAbleToGetTheRegistration() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("24-D-1234", rentalCar.RegId);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetTheMake() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("Toyota", rentalCar.Make);
    }


    [Fact]
    public void Car_ShouldBeAbleToGetTheModel() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("CH-R", rentalCar.Model);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetTheColor() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("Metalic Silver", rentalCar.Color);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetTheYear() {
        Car rentalCar = CreateCarObject();
        Assert.Equal(2024, rentalCar.Year);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetNoOfDoors() {
        Car rentalCar = CreateCarObject();
        Assert.Equal(5, rentalCar.NoOfDoors);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetTrunkCapacity() {
        Car rentalCar = CreateCarObject();
        Assert.Equal(100, rentalCar.TrunkCapacity);
    }

    [Fact]
    public void Car_ShouldBeAbleToGetIsConvertable() {
        Car rentalCar = CreateCarObject();
        Assert.True(rentalCar.IsConvertable);
    }

    private Car CreateCarObject() {
        return new Car("24-D-1234", "Toyota", "CH-R", 2024, "Metalic Silver", 1.6, "Petrol", 5, true, 100, true);
    }
}