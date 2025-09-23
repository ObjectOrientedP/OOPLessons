using System;

public class CreditCardPayment : PaymentProcessor, IPaymentSecurity
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}...");
    }

    public void ApplySecurityCheck()
    {
        Console.WriteLine("Credit card security check applied.");
    }
}