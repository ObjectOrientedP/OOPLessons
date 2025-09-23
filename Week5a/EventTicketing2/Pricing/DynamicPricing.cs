namespace EventTicketing.Pricing;

public class DynamicPricing : IPricingStrategy
{
    public double GetPrice(double basePrice, int soldTickets, int capacity)
    {
        // Calculate the percentage of tickets sold
        double soldPercentage = (double)soldTickets / capacity;

        //Adjust the price based on the percentage sold
        if (soldPercentage > 0.9)
        {
            return basePrice * 1.5; // Increase by 50% when 90% of tickets are sold
        }
        else if (soldPercentage > 0.75)
        {
            return basePrice * 1.25; // Increase by 25% when 75% of tickets are sold
        }
        else if (soldPercentage > 0.5)
        {
            return basePrice * 1.1; // Increase by 10% when 50% of tickets are sold
        }
        else
        {
            return basePrice; // Base price for less than 50% sold
        }
    }
}
