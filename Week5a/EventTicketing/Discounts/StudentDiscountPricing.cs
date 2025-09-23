using EventTicketing.Strategy;

namespace EventTicketing.Strategy;

public class StudentDiscountPricing : DiscountedPricing
{
    public override double CalculatePrice()
    {
        //apply a 15% discount for students
        return BasePrice * 0.85;
    }
}