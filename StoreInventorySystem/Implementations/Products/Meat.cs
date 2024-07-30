using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Products;

public class Meat : Product
{
    public Meat(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    string CountAmount()
    {
        return $"{Quantity} kgs";
    }
}