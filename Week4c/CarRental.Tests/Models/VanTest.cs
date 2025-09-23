using Xunit;
using CarRental.Models;

public class VanTest 
{
    [Fact]
    public void VanTest_ShouldBeInstanceOfVehicle()
    {
        Van rentalVan = CreateVanObject();
        Assert.IsType<Van>(rentalVan);
        Assert.IsAssignableFrom<Vehicle>(rentalVan);        
    }

    [Fact]
    public void Van_ShouldAccessSlidingDoor()
    {
        Van rentalVal = CreateVanObject();
        Assert.True(rentalVal.IsSlidingDoor());
    }

        [Fact]
    public void Van_ShouldProvideMaxCapicty()
    {
        Van rentalVal = CreateVanObject();
        Assert.Equal(8, rentalVal.GetCapacity());
    }

    [Theory]
    [InlineData(1, 45.0, 45.0)]
    [InlineData(4, 45.0, 180.0)]
    [InlineData(0, 45.0, 0)]
    [InlineData(0, 0, 0)]
    public void Van_ShouldApplyCorrectDailyRate(int days, double rate, double expectedCost)
    {
        Van rentalVan = CreateVanObject();

        double actualCost = rentalVan.CalculateRentalFee(days, rate);

        Assert.Equal(expectedCost, actualCost);
    }

    private Van CreateVanObject() {
        return new Van("24-D-1234", "Toyota", "CH-R", 2024, "Metalic Silver", 1.6, "Petrol", 5, true, true, 8);
    }
}