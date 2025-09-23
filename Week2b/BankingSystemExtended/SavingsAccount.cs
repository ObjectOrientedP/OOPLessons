class SavingsAccount : BankAccount {

    private decimal interestRate;
    public SavingsAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestrate) : base(accountNumber, accountHolderName, balance) {
        this.interestRate = interestrate;
    }

    public void ApplyInterest() {
        decimal interest = (balance * interestRate) / 100;
        balance += interest;        
    }

    public override void GetAccountDetails()
    {
        base.GetAccountDetails();
        Console.WriteLine($"Interest Rate: {interestRate}%");
    }

}