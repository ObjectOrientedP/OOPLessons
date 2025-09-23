using System;

namespace CarRental.Models;
public class Truck : Vehicle
{
    private int PayloadCapacity;
    public Truck(string RegId, string Make, string Model, int Year, string Color, double EngineSize, string EngineType, int NoOfDoors, bool IsAutomatic, int PayloadCapacity) : base(RegId, Make, Model, Year, Color, EngineSize, EngineType, NoOfDoors, IsAutomatic){
        this.PayloadCapacity = PayloadCapacity;
    }

    public int GetPayloadCapacity()
    {
        return this.PayloadCapacity;
    }

    public override double CalculateRentalFee(int daysRented)
    {
        return daysRented * 150.0;
    }    
}