using System;
using CarRental.Models;
using CarRental.Services;

public class Program
{
    public static void Main(string[] args)
    {

        VehicleLinkedList vehicleList = new VehicleLinkedList();
        ReservationQueue reservationQueue = new ReservationQueue();

        // Adding sample cars to the system
        vehicleList.AddVehicle(new Car("24-D-1234", "Toyota", "CH-R", 2024, "Metalic Silver", 1.6, "Petrol", 5, true, 100, true));
        vehicleList.AddVehicle(new Car("18-C-5678", "Honda", "Civic", 2021, "Blue", 1.8, "Petrol", 5, true, 80, true));
        vehicleList.AddVehicle(new Car("22-A-9876", "Ford", "Fiesta", 2022, "Red", 1.2, "Diesel", 5, true, 60, false));
        vehicleList.AddVehicle(new Car("23-EV-2345", "Tesla", "Model 3", 2023, "White", 0, "Electric", 5, true, 150, true));


        vehicleList.AddVehicle(new Van("20-V-3456", "Dodge", "Grand Caravan", 2020, "Silver", 3.6, "Petrol", 7, true, true, 7));
        vehicleList.AddVehicle(new Van("21-V-6543", "Ford", "Transit", 2021, "White", 3.5, "Diesel", 3, false, false, 6));


        vehicleList.AddVehicle(new Truck("19-T-7654", "Ford", "F-150", 2019, "Black", 3.5, "Diesel", 5, true, 120));
        vehicleList.AddVehicle(new Truck("17-T-2345", "Ram", "2500", 2018, "Gray", 6.7, "Diesel", 5, true, 150));



        // Create menu and show it
        Menu menu = new Menu(vehicleList, reservationQueue);
        menu.ShowMenu();
    }
}
