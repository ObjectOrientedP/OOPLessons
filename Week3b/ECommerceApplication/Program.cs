
//string name, double price, double weight, string isbn, string author, string genre, int pages

Book book = new Book("To Catch a Killer", 13.99, 1.5, "A343242", "Some Author", "Thriller", 402);
book.DisplayDetails();
Console.WriteLine("Total Shipping Costs: " + book.CalculateShippingCost(2.0));

Console.WriteLine("  ***************************   ");

Electronic electronic = new Electronic("Dyson", 299.00, 22.5, 5, "Electric", false, "IE45324", 'D');
Console.WriteLine("Total Shipping Costs: " + electronic.CalculateShippingCost(8.0));