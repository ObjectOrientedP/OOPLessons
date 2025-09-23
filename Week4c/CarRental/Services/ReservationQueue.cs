using CarRental.Models;

namespace CarRental.Services;


public class ReservationQueue
{
    private Queue<Reservation> reservations = new Queue<Reservation>();

    public void AddReservation(Reservation reservation)
    {
        reservations.Enqueue(reservation);
    }

    public void ProcessReservations()
    {
        while (reservations.Count > 0)
        {
            Reservation reservation = reservations.Dequeue();
            double fee = reservation.ReservedVehicle.CalculateRentalFee(reservation.DaysRented);
            Console.WriteLine($"{reservation.CustomerName} reserved {reservation.ReservedVehicle.Model} for {reservation.DaysRented} days. Total fee: {fee:C}");
        }
    }
}