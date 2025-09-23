using EventTicketing.Delivery;
using EventTicketing.Events;
using EventTicketing.Pricing;

namespace EventTicketing.Tickets;

public abstract class Ticket
{
    public Guid TicketId { get; private set; }
    public Event Event { get; private set; }
    private double price; 
    public ITicketDelivery DeliveryMethod { get; private set; }
    public IPricingStrategy PricingStrategy { get; private set; }

    public Ticket(Event eventObj, ITicketDelivery deliveryMethod)
    {
        TicketId = Guid.NewGuid();
        Event = eventObj;
        DeliveryMethod = deliveryMethod;

        price = Event.GetBasePriceForTicket(this.GetType());
    }

    public Ticket(Event eventObj, ITicketDelivery deliveryMethod, IPricingStrategy pricingStrategy)
    {
        TicketId = Guid.NewGuid();
        Event = eventObj;
        DeliveryMethod = deliveryMethod;
        PricingStrategy = pricingStrategy;
        //we need to set and store the price
        price = PricingStrategy.GetPrice(Event.GetBasePriceForTicket(this.GetType()), Event.GetTotalSoldTickets(), Event.Capacity);
    }

    public double GetPrice()
    {
        return price;
    }

    public virtual double CalculatePrice()
    {
        //For events with no pricing strategy
        if(PricingStrategy == null) {
            return Event.GetBasePriceForTicket(this.GetType());
        }

        return PricingStrategy.GetPrice(Event.GetBasePriceForTicket(this.GetType()), Event.GetTotalSoldTickets(), Event.Capacity);
    }

    public void DeliverTicket()
    {
        DeliveryMethod.Deliver();
    }

    public override string ToString()
    {
        return $"Ticket ID: {TicketId}, Type: {this.GetType().Name} Event: {Event.Name}, Price: ${GetPrice()}";
    }
}