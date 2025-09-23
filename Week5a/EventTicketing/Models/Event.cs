using System;
using EventTicketing.Strategy;
using EventTicketing.Delivery;

namespace EventTicketing.Models;


public abstract class Event 
{
    public Guid EventId { get; set; }
    public string Name { get; set; }

    public int Capacity {get; set;}

    public DateTime StartDate { get; set; }

    public DateTime EndDate {get; set;}

    public PricingStrategy PricingStrategy { get; set; }

     public ITicketDelivery TicketDelivery { get; set; }

    public Event(Guid eventId, string name, int capacity, DateTime startDate, DateTime endDate, PricingStrategy pricingStrategy, ITicketDelivery ticketDelivery) {
        EventId = eventId;
        Name = name;
        Capacity = capacity;
        StartDate = startDate;
        EndDate = endDate;
        PricingStrategy = pricingStrategy;
        TicketDelivery = ticketDelivery;
    }

    public abstract void DisplayDetails();  
    public double CalculatePrice() => PricingStrategy.CalculatePrice();
    public void DeliverTicket() => TicketDelivery.Deliver();

}