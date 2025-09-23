namespace EventTicketing.Delivery;


public class PhysicalDelivery : ITicketDelivery
{
    public void Deliver() 
    {
        Console.WriteLine("Tickets delivered by mail");
    }
}