using EventTicketing.Strategy;

namespace EventTicketing.Discounts;

public class SeniorDiscountPricing : DiscountedPricing
{
    public override double CalculatePrice()
    {
        //20% discount for seniors
        return BasePrice * 0.80; 
    }
}