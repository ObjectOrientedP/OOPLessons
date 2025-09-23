using System;

public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(double amount);

    public void ValidatePayment() {
        Console.WriteLine("Payment validation in progress...");
    }
}