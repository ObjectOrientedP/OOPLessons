public interface IProduct {
    void DisplayDetails();
    double CalculateShippingCost(double cost);
    void ApplyDiscount(double discountPercentage);
}