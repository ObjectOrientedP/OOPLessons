namespace EventTicketing.Pricing;


public interface IPricingStrategy
{
    double GetPrice(double basePrice, int soldTickets, int capacity);
}

