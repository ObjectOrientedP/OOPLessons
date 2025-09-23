using System;
using CarRental.Models;


namespace CarRental.Services;

public class Menu
{
    private VehicleLinkedList vehicleList;
    private ReservationQueue reservationQueue;

    public Menu(VehicleLinkedList vehicleList, ReservationQueue reservationQueue)
    {
        this.vehicleList = vehicleList;
        this.reservationQueue = reservationQueue;
    }

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\nCar Rental System Menu:");
            Console.WriteLine("1. View Available Vehicles");
            Console.WriteLine("2. Make a Reservation");
            Console.WriteLine("3. Process Reservations");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    vehicleList.DisplayAvailableVehicles();
                    break;
                case 2:
                    MakeReservation();
                    break;
                case 3:
                    reservationQueue.ProcessReservations();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        } while (choice != 4);
    }

    private void MakeReservation()
    {
        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();
        Console.Write("Enter Car License Plate to Reserve: ");
        string licensePlate = Console.ReadLine();
        Console.Write("Enter Days to Rent: ");
        int daysRented = int.Parse(Console.ReadLine());

        Vehicle vehicleToRent = vehicleList.RentVehicle(licensePlate);
        if (vehicleToRent != null)
        {
            Reservation reservation = new Reservation(customerName, vehicleToRent, daysRented);
            reservationQueue.AddReservation(reservation);
            Console.WriteLine("Reservation made successfully!");
        }
        else
        {
            Console.WriteLine("Vehicle not available or invalid license plate.");
        }
    }
}