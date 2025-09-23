using System;

namespace CarRental.Models;
public class Van : Vehicle
{
    public Van(string RegId, string Make, string Model, int Year, string Color, double EngineSize, string EngineType, int NoOfDoors, bool IsAutomatic) : base(RegId, Make, Model, Year, Color, EngineSize, EngineType, NoOfDoors, IsAutomatic){

    }

    public override double CalculateRentalFee(int days)
    {
        return days * 50; 
    }
}
