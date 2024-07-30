using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Products;

public class Fish : Product
{
    public Fish(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    string CountAmount()
    {
        return $"{Quantity} kgs";
    }
}