using System;

class Program
{
    static void Main(string[] args)
    {
        IPaymentSecurity creditCard = new CreditCardPayment();
        creditCard.ValidatePayment();
        creditCard.ApplySecurityCheck();
        creditCard.ProcessPayment(100.00);

    }
}
