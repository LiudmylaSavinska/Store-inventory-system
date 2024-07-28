using StoreInventorySystem.Contracts;
using StoreInventorySystem.Implementations.Products;
using StoreInventorySystem.Implementations.Products.Base;
using StoreInventorySystem.Implementations.Store.StoreSections;

namespace StoreInventorySystem.Implementations.Store;

public class Store
{
    public Store()
    {
        Seed();
        GetFullList();
    }
    
    public List<ICountable> StoreSections { get; set; }

    public void GetFullList()
    {
        foreach (var storeSection in StoreSections)
        {
            Console.WriteLine($"{storeSection.SectionName} {storeSection.CountAmount()}");
            Console.WriteLine(storeSection.PrintAmount());
        }
    }

    private void Seed()
    {
        StoreSections = new List<ICountable>();
        
        var beverageStoreSection = new BeverageStoreSection();
        
        beverageStoreSection.Products.Add(new Beverage("Cola", 20, 10));
        beverageStoreSection.Products.Add(new Beverage("Snaps", 44, 210));
        beverageStoreSection.Products.Add(new Beverage("Juice", 11, 130));
        beverageStoreSection.Products.Add(new Beverage("Water", 220, 150));
        
        StoreSections.Add(beverageStoreSection);
        
    }
}