using System;

public class PayPalPayment : PaymentProcessor, IPaymentSecurity
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}...");
    }

    public void ApplySecurityCheck()
    {
        Console.WriteLine("PayPal security check applied.");
    }
}