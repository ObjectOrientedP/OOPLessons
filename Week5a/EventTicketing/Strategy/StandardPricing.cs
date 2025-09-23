namespace EventTicketing.Strategy;


public class StandardPricing : PricingStrategy
{
    public override double CalculatePrice() {
        return 50.0;
    }
}