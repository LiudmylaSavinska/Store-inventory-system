using StoreInventorySystem.Contracts;
using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Store.StoreSections;

public class VegetablesStoreSection : ICountable
{
    public List<Product> Products { get; set; }

    public string SectionName { get; }
    
    public string UnitType { get; }
    
    public VegetablesStoreSection()
    {
        Products = new List<Product>();
        UnitType = "kilograms";
        SectionName = "Vegetables";
    }

    public int CountAmount()
    {
        return Products.Sum(product => product.Quantity);
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