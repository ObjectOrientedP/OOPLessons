using EventTicketing.Events;
using EventTicketing.Delivery;
using EventTicketing.Pricing;

namespace EventTicketing.Tickets;

public class StandardTicket : Ticket
{
    public StandardTicket(Event eventObj, ITicketDelivery deliveryMethod)
        : base(eventObj, deliveryMethod) { }

    public StandardTicket(Event eventObj, ITicketDelivery deliveryMethod, IPricingStrategy pricingStrategy)
        : base(eventObj, deliveryMethod, pricingStrategy) { }
}