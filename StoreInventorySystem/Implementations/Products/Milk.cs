using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Products;

public class Milk : Product
{
    public Milk(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    string CountAmount()
    {
        return $"{Quantity} lts";
    }
}