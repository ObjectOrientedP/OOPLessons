using System;
public class Electronic : Product
{
    public int _warrantyPeriod { get; set; } 
    public string _powerSource { get; set; } 
    public bool _isSmartDevice { get; set; }
    public string _modelNumber { get; set; }
    public char _energyRating { get; set; }

    // Constructor
    public Electronic(string name, double price, double weight, int warranty, string powerSource, bool isSmartDevice, string modelNumber, char energyRating)
        : base(name, price, weight)
    {
        _warrantyPeriod = warranty;
        _powerSource = powerSource;
        _isSmartDevice = isSmartDevice;
        _modelNumber = modelNumber;
        _energyRating = energyRating;
    }

    public override double CalculateShippingCost(double cost) {
        return 100.00 * cost;
    }



}