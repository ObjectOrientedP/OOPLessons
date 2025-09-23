using InventoryManagement.Events;

namespace InventoryManagement.Inventory;

public class InventoryManager
{
    public void Subscribe(IInventory inventory)
    {
        inventory.StockThresholdReached += OnStockThresholdReached;
    }

    // Event handler method
    private void OnStockThresholdReached(object sender, StockEventArgs e)
    {
        Console.WriteLine($"Warning: The stock of {e.ProductName} is low (Current stock: {e.Stock}). Consider reordering.");
    }
}
