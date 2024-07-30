using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Products;

public class Vegetables : Product
{
    public Vegetables(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    string CountAmount()
    {
        return $"{Quantity} kgs";
    }
}