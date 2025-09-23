using InventoryManagement.Events;

namespace InventoryManagement.Inventory;
public class Inventory : IInventory
{
    public event StockThresholdReachedEventHandler StockThresholdReached;

    private Dictionary<string, int> _products = new Dictionary<string, int>();
    private int _criticalLevel = 5;

    // Add product with initial stock
    public void AddProduct(string productName, int stock)
    {
        _products[productName] = stock;
    }

    // Reduce stock of a product
    public void ReduceStock(string productName, int quantity)
    {
        if (_products.ContainsKey(productName))
        {
            _products[productName] -= quantity;
            
            // Check if stock falls below the critical level
            if (_products[productName] <= _criticalLevel)
            {
                OnStockThresholdReached(productName, _products[productName]);
            }
        }
    }

    // Raise the event if stock is low
    protected virtual void OnStockThresholdReached(string productName, int stock)
    {
        StockThresholdReached?.Invoke(this, new StockEventArgs(productName, stock));
    }
}