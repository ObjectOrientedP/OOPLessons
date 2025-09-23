using EventTicketing.Strategy;

namespace EventTicketing.Strategy;

public class DynamicPricing : PricingStrategy
{
    private double demandFactor;

    public DynamicPricing(double demandFactor)
    {
        this.demandFactor = demandFactor;
    }

    public override double CalculatePrice()
    {
        //Price based on demand via Constructor param!
        return 50.0 * demandFactor; 
    }
}
