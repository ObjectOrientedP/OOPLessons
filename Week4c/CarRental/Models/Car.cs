using System;

namespace CarRental.Models;

public class Car : Vehicle {
    public int TrunkCapacity { get; set; }
    public bool IsConvertable { get; set; }

    public Car(string RegId, string Make, string Model, int Year, string Color, double EngineSize, string EngineType, int NoOfDoors, bool IsAutomatic, int TrunkCapacity, bool IsConvertable) 
    : base(RegId, Make, Model, Year, Color, EngineSize, EngineType, NoOfDoors, IsAutomatic)
    {
        this.TrunkCapacity = TrunkCapacity;
        this.IsConvertable = IsConvertable;
    }

    public override double CalculateRentalFee(int daysRented)
    {
        return daysRented * 50.0;
    }

}