using EventTicketing.Strategy;

namespace EventTicketing.Discounts;

public class PromotionalDiscountPricing : DiscountedPricing
{
    public override double CalculatePrice()
    {
        //10% promotional discount
        return BasePrice * 0.90; 
    }
}