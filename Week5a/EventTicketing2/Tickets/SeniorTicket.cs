using EventTicketing.Events;
using EventTicketing.Delivery;
using EventTicketing.Pricing;

namespace EventTicketing.Tickets;

public class SeniorTicket : Ticket
{
    public SeniorTicket(Event eventObj, ITicketDelivery deliveryMethod)
        : base(eventObj, deliveryMethod) { }
        
    public SeniorTicket(Event eventObj, ITicketDelivery deliveryMethod, IPricingStrategy pricingStrategy)
        : base(eventObj, deliveryMethod, pricingStrategy) { }
}