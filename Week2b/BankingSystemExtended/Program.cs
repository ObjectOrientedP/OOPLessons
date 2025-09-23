// BankAccount bankAccount = new BankAccount("A123123", "Andy Fitzgerald", 0);

SavingsAccount savingsAccount = new SavingsAccount("S124132", "Andy Fitzgerald", 1000.00m, 4.3m);
savingsAccount.GetAccountDetails();
savingsAccount.ApplyInterest();
savingsAccount.GetAccountDetails();

for(int i = 0; i < 20; i++) {
    savingsAccount.ApplyInterest();
    savingsAccount.GetAccountDetails();
}
