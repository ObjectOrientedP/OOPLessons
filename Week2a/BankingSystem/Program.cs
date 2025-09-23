using System;

public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nWelcome to the Banking System!");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Check balance");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter account number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter account holder name: ");
                        string accountHolderName = Console.ReadLine();
                        account = new BankAccount(accountNumber, accountHolderName, 0);
                        Console.WriteLine("Account created successfully!");
                        break;

                    case "2":
                        if (account != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            decimal depositAmount;
                            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                            {
                                account.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No account found. Please create an account first.");
                        }
                        break;

                    case "3":
                        if (account != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            decimal withdrawAmount;
                            if (decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                            {
                                account.Withdraw(withdrawAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No account found. Please create an account first.");
                        }
                        break;

                    case "4":
                        if (account != null)
                        {
                            Console.WriteLine($"Your current balance is: {account.GetBalance()}");
                        }
                        else
                        {
                            Console.WriteLine("No account found. Please create an account first.");
                        }
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Thank you for using the Banking System!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
}


