using EventTicketing.Strategy;
using EventTicketing.Delivery;

namespace EventTicketing.Models;


public class SportsGame : Event 
{
    public SportsGame(Guid eventId, string name, int capacity, DateTime startDate, DateTime endDate, PricingStrategy pricingStrategy, ITicketDelivery delivery) 
    : base(eventId, name, capacity, startDate, endDate, pricingStrategy, delivery) 
    {}

    public override void DisplayDetails()
    {
        Console.WriteLine($"Sporting Event: {Name}, Capacity: {Capacity}, StartDate: {StartDate}, EndDate {EndDate}");
    }

}