using EventTicketing.Events;
using EventTicketing.Delivery;
using EventTicketing.Pricing;

namespace EventTicketing.Tickets;

public class StudentTicket : Ticket
{
    public StudentTicket(Event eventObj, ITicketDelivery deliveryMethod)
        : base(eventObj, deliveryMethod) { }
        
    public StudentTicket(Event eventObj, ITicketDelivery deliveryMethod, IPricingStrategy pricingStrategy)
        : base(eventObj, deliveryMethod, pricingStrategy) { }
}