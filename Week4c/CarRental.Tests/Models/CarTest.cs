using Xunit;
using CarRental.Models;

public class CarTest
{

    [Fact]
    public void Car_ShouldBeInstanceOfVehicle() 
    {
        Car rentalCar = CreateCarObject();
        Assert.IsType<Car>(rentalCar);
        Assert.IsAssignableFrom<Vehicle>(rentalCar);
    }

    [Fact]
    public void Car_ShouldHaveAllAttributes() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("24-D-1234", rentalCar.RegId);
        Assert.Equal("Toyota", rentalCar.Make);
    }

    [Fact]
    public void Car_ShouldBeAbleToAccessRegId() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("24-D-1234", rentalCar.RegId);
    }

    [Fact]
    public void Car_ShouldBeAbleToAccessMake() {
        Car rentalCar = CreateCarObject();
        Assert.Equal("Toyota", rentalCar.Make);
    }

    [Theory]
    [InlineData(1, 20.0, 20.0)]
    [InlineData(4, 25.0, 100.0)]
    [InlineData(0, 25.0, 0)]
    [InlineData(0, 0, 0)]
    public void Car_ShouldApplyCorrectDailyRate(int days, double rate, double expectedCost)
    {
        Car rentalCar = CreateCarObject();

        double actualCost = rentalCar.CalculateRentalFee(days, rate);

        Assert.Equal(expectedCost, actualCost);
    }

    private Car CreateCarObject() {
        return new Car("24-D-1234", "Toyota", "CH-R", 2024, "Metalic Silver", 1.6, "Petrol", 5, true, 100, true);
    }

}

