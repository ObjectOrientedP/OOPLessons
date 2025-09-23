using InventoryManagement.Events;

namespace InventoryManagement.Inventory;

public interface IInventory
{
    void AddProduct(string productName, int stock);

    void ReduceStock(string productName, int quantity);

    event StockThresholdReachedEventHandler StockThresholdReached;
}