namespace EventTicketing.Delivery;


public class DigitalDelivery : ITicketDelivery
{
    public void Deliver() 
    {
        Console.WriteLine("Ticket delivered by e-mail");
    }
}