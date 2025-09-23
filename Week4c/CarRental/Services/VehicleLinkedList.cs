using CarRental.Models;

namespace CarRental.Services;

public class VehicleLinkedList
{
    public class VehicleNode
    {
        public Vehicle Vehicle { get; set; }
        public VehicleNode Next { get; set; }

        public VehicleNode(Vehicle v)
        {
            Vehicle = v;
        }
    }

    private VehicleNode head;

    public void AddVehicle(Vehicle vehicle)
    {
        VehicleNode newNode = new VehicleNode(vehicle);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            VehicleNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public void DisplayAvailableVehicles()
    {
        VehicleNode current = head;
        Console.WriteLine("Available Vehicles:");
        while (current != null)
        {
            if (current.Vehicle.IsAvailable)
            {
                Console.WriteLine($"{current.Vehicle.GetType().Name}: {current.Vehicle.Model} (License: {current.Vehicle.RegId})");
            }
            current = current.Next;
        }
    }

    public Vehicle RentVehicle(string regId)
    {
        VehicleNode current = head;
        while (current != null)
        {
            if (current.Vehicle.RegId == regId && current.Vehicle.IsAvailable)
            {
                current.Vehicle.IsAvailable = false;
                return current.Vehicle;
            }
            current = current.Next;
        }
        return null;
    }
}