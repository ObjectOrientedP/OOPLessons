using EventTicketing.Pricing;
using EventTicketing.Delivery;
using EventTicketing.Tickets;

namespace EventTicketing.Events;

public abstract class Event 
{
    public Guid EventId { get; private set; }
    public string Name { get; set; }
    public int Capacity {get; set;}
    private int totalTicketsSold = 0;
    private Dictionary<Type, double> ticketPrices = new Dictionary<Type, double>();
    private List<Ticket> tickets = new List<Ticket>();

    public Event(string name, int capacity) {
        EventId = Guid.NewGuid();
        Name = name;
        Capacity = capacity;
    }

    public Ticket CreateTicket(Ticket ticket)
    {
        if(totalTicketsSold >= Capacity) {
            return null;
        }

        var ticketType = ticket.GetType();

        if(ticketPrices.ContainsKey(ticketType)) {
            tickets.Add(ticket);
            totalTicketsSold++;
        } else {
            Console.WriteLine("Ticket Type not availale for this Event");
            return null;
        }

        return ticket;
    }

    public void SetTicketPrice<T>(double price) where T : Ticket
    {
        ticketPrices[typeof(T)] = price;
    }

    public double GetTicketPrice<T>() where T : Ticket
    {
        return ticketPrices.ContainsKey(typeof(T)) ? ticketPrices[typeof(T)] : throw new ArgumentException("Price not set for this ticket type.");
    }

    public virtual double GetBasePriceForTicket(Type ticketType)
    {
        return GetTicketPrice(ticketType);
    }

    public double GetTicketPrice(Type ticketType)
    {
        if (ticketPrices.ContainsKey(ticketType))
            return ticketPrices[ticketType];

        throw new ArgumentException("Ticket price not set for this type.");
    }

    public int GetTotalSoldTickets()
    {
        return totalTicketsSold;
    }

    public void DisplayTickets()
    {
        foreach (var ticket in tickets)
        {
            Console.WriteLine(ticket);
        }
    }
    public abstract void DisplayDetails();  

}