using System;

namespace CarRental.Models;
public class Van : Vehicle
{
    private bool HasSlidingDoor;
    private int MaxPassengerCapacity;


    public Van(string RegId, string Make, string Model, int Year, string Color, double EngineSize, string EngineType, int NoOfDoors, bool IsAutomatic, bool HasSlidingDoor, int MaxPassengerCapacity)
    : base(RegId, Make, Model, Year, Color, EngineSize, EngineType, NoOfDoors, IsAutomatic)
    {
        this.HasSlidingDoor = HasSlidingDoor;
        this.MaxPassengerCapacity = MaxPassengerCapacity;
    }

    public bool IsSlidingDoor()
    {
        return this.HasSlidingDoor;
    }

    public int GetCapacity()
    {
        return this.MaxPassengerCapacity;
    }

    public override double CalculateRentalFee(int daysRented)
    {
        return daysRented * 100.0;
    }

}
