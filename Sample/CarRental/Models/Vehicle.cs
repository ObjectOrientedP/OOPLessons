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