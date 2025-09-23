namespace InventoryManagement.Events;

public class StockEventArgs : EventArgs
{
    public string ProductName { get; }
    public int Stock { get; }

    public StockEventArgs(string productName, int stock)
    {
        ProductName = productName;
        Stock = stock;
    }
}