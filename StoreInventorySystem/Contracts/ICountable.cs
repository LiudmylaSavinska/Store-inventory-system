using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Contracts;

public interface ICountable
{
    public List<Product> Products { get; set; }

    public string SectionName { get; }
    
    public string UnitType { get; }
    
    int CountAmount();
    
    string PrintAmount();
}