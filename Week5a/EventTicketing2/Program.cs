using EventTicketing.Events;
using EventTicketing.Tickets;
using EventTicketing.Delivery;
using EventTicketing.Pricing;

public class Program
{
    public static void Main()
    {

        Concert concert = new Concert("Rock Concert", 20);
        concert.SetTicketPrice<StandardTicket>(120.00);
        concert.SetTicketPrice<StudentTicket>(85.00);


        for (int i = 0; i < 10; i++) {
            concert.CreateTicket(new StandardTicket(concert, new DigitalDelivery()));
            concert.CreateTicket(new StudentTicket(concert, new DigitalDelivery()));
        }
        concert.DisplayDetails();
        concert.DisplayTickets();
        Console.WriteLine($"Total Tickets Sold: {concert.GetTotalSoldTickets()}");


        Console.WriteLine("");
        Console.WriteLine("********************** SPORTS EVENT ************************");
        Console.WriteLine("");

        SportingEvent sportingEvent = new SportingEvent("Rep. Ireland v Greece", 20);
        sportingEvent.SetTicketPrice<StandardTicket>(55.00);
        sportingEvent.SetTicketPrice<StudentTicket>(40.00);
        sportingEvent.SetTicketPrice<SeniorTicket>(35.00);

        IPricingStrategy pricingStrategy = new DynamicPricing();

        for (int i = 0; i <= 8; i++)
        {
            sportingEvent.CreateTicket(new StandardTicket(sportingEvent, new DigitalDelivery(), pricingStrategy));
        }

        for (int i = 0; i <= 10; i++)
        {
            sportingEvent.CreateTicket(new SeniorTicket(sportingEvent, new DigitalDelivery(), pricingStrategy));
        }

        sportingEvent.DisplayDetails();
        sportingEvent.DisplayTickets();
        Console.WriteLine($"Total Tickets Sold: {sportingEvent.GetTotalSoldTickets()}");



    }
}