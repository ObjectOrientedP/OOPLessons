using System;

namespace CarRental.Models;
public class Customer
{
    public string Name { get; set; }
    public string LicenseNumber { get; set; }

    public Customer(string name, string licenseNumber)
    {
        Name = name;
        LicenseNumber = licenseNumber;
    }

    public override string ToString()
    {
        return $"Customer: {Name}, License: {LicenseNumber}";
    }
}
