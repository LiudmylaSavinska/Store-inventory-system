using StoreInventorySystem.Contracts;
using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Store.StoreSections;

public class MeatStoreSection : ICountable
{
    public List<Product> Products { get; set; }

    public string SectionName { get; }
    public string UnitType { get; }
    
    public MeatStoreSection()
    {
        Products = new List<Product>();
        UnitType = "kilograms";
        SectionName = "Meat";
    }

    public int CountAmount()
    {
        var amount = 0;

        foreach (var product in Products)
        {
            amount += product.Quantity;
        }

        return amount;
    }

    public string PrintAmount()
    {
        var details = string.Empty;
        
        foreach (var product in Products)
        {
            details += $"{product.Name} {product.Quantity} {UnitType} \n";
        }

        return details;
    }
}