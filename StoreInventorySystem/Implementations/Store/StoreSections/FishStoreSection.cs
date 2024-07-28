using StoreInventorySystem.Contracts;
using StoreInventorySystem.Implementations.Products.Base;

namespace StoreInventorySystem.Implementations.Store.StoreSections;

public class FishStoreSection  : ICountable
{
    public List<Product> Products { get; set; }

    public string SectionName { get; }
    public string UnitType { get; }
    
    public int CountAmount()
    {
        throw new NotImplementedException();
    }

    public string PrintAmount()
    {
        throw new NotImplementedException();
    }
}