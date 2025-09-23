using InventoryManagement.Events;
using InventoryManagement.Inventory;


class Program
{
    static void Main(string[] args)
    {
        IInventory inventory = new Inventory();
        InventoryManager manager = new InventoryManager();

        // Subscribe to the stock threshold event
        manager.Subscribe(inventory);

        // Add some products to the inventory
        inventory.AddProduct("Laptop", 10);
        inventory.AddProduct("Smartphone", 8);

        // Simulate some sales or product usage
        inventory.ReduceStock("Laptop", 4);
        inventory.ReduceStock("Smartphone", 4);
        inventory.ReduceStock("Laptop", 2);  // Should trigger an event
        inventory.ReduceStock("Smartphone", 5);  // Should trigger an event
    }
}
