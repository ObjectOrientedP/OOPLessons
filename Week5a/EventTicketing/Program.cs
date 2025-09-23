using EventTicketing.Models;
using EventTicketing.Strategy;
using EventTicketing.Delivery;
using EventTicketing.Discounts;

public class Program
{
    public static void Main()
    {

        Event concert = new Concert(
            Guid.NewGuid(), "Rock Concert", 10000, new DateTime(2024, 12, 15, 18, 30, 0), new DateTime(2024, 12, 20, 18, 30, 0), new StandardPricing(), new DigitalDelivery());

        Event sportsGame = new SportsGame(
            Guid.NewGuid(), "Football Match", 50000, new DateTime(2025, 01, 01, 14, 30, 0), new DateTime(2025, 01, 01, 16, 00, 0), new StudentDiscountPricing(), new PhysicalDelivery());

        Event theater = new Theater(
            Guid.NewGuid(), "Shakespeare Play", 1000, new DateTime(2025, 01, 16, 20, 30, 0), new DateTime(2025, 01, 16, 22, 30, 0), new SeniorDiscountPricing(), new DigitalDelivery());

        concert.DisplayDetails();
        Console.WriteLine($"Price: ${concert.CalculatePrice()}");
        concert.DeliverTicket();

        sportsGame.DisplayDetails();
        Console.WriteLine($"Price (Student Discount): ${sportsGame.CalculatePrice()}");
        sportsGame.DeliverTicket();

        theater.DisplayDetails();
        Console.WriteLine($"Price (Senior Discount): ${theater.CalculatePrice()}");
        theater.DeliverTicket();
    }
}