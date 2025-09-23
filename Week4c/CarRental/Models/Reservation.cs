using System;

namespace CarRental.Models;
public class Reservation
{
    public string CustomerName { get; set; }
    public Vehicle ReservedVehicle { get; set; }
    public int DaysRented { get; set; }

    public Reservation(string customerName, Vehicle reservedVehicle, int daysRented)
    {
        CustomerName = customerName;
        ReservedVehicle = reservedVehicle;
        DaysRented = daysRented;
    }
}