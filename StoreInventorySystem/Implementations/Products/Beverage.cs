using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Products;

public class Beverage : Product
{
    public Beverage(string name, double price, int quantity) : base(name, price, quantity)
    {
    }

    string CountAmount()
    {
        return $"{Quantity} pc";
    }
}