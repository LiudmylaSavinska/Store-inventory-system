using System.Net.Http.Headers;
using StoreInventorySystem.Contracts;
using StoreInventorySystem.Implementations.Products;
using StoreInventorySystem.Implementations.Products.Base;
using StoreInventorySystem.Implementations.Store.StoreSections;

namespace StoreInventorySystem.Implementations.Store;

public class Store
{
    public Store()
    {
        StoreSections = new List<ICountable>();
        Seed();
        GetFullList();
    }
    
    public List<ICountable> StoreSections { get; set; }

    public void AddProduct(string productName, string productSection, double productPrice, int productQuantity)
    {
        var storeSection = StoreSections.FirstOrDefault(ss => ss.SectionName == productSection);
        
        if (storeSection == null)
        {
            Console.WriteLine("The section is not found");
            
            return;
        }

        Product product;
        
        switch (productSection)
        {
            case "Beverage":
                product = new Beverage(productName, productPrice, productQuantity);
                storeSection.Products.Add(product);
                break;
            
            case "Fish":
                product = new Fish(productName, productPrice, productQuantity);
                storeSection.Products.Add(product);
                break;
            
            case "Meat":
                product = new Meat(productName, productPrice, productQuantity);
                storeSection.Products.Add(product);
                break;
            
            case "Milk":
                product = new Milk(productName, productPrice, productQuantity);
                storeSection.Products.Add(product);
                break;
            
            case "Vegetables":
                product = new Vegetables(productName, productPrice, productQuantity);
                storeSection.Products.Add(product);
                break;
        }
    }

    public void RemoveProduct(string productName, string productSection)
    {
        var storeSection = StoreSections.FirstOrDefault(ss => ss.SectionName == productSection);
        
        if (storeSection == null)
        {
            Console.WriteLine("The section is not found");
            
            return;
        }

        var product = storeSection.Products.FirstOrDefault(p => p.Name == productName);
        
        if (product == null)
        {
            Console.WriteLine("The product is not found");
            
            return;
        }

        storeSection.Products.Remove(product);

    }
    
    public void GetFullList()
    {
        foreach (var storeSection in StoreSections)
        {
            Console.WriteLine($"{storeSection.SectionName} {storeSection.CountAmount()}");
            Console.WriteLine(storeSection.PrintAmount());
        }
    }

    public void GetSectionList(string sectionName)
    {
        var storeSection = StoreSections.FirstOrDefault(ss => ss.SectionName == sectionName);

        if (storeSection == null)
        {
            Console.WriteLine("The section is not found");
        }
        
        storeSection.PrintAmount();
    }

    private void Seed()
    {
        var beverageStoreSection = new BeverageStoreSection();
        
        beverageStoreSection.Products.Add(new Beverage("Cola", 20, 10));
        beverageStoreSection.Products.Add(new Beverage("Snaps", 44, 210));
        beverageStoreSection.Products.Add(new Beverage("Juice", 11, 130));
        beverageStoreSection.Products.Add(new Beverage("Water", 220, 150));
       
        var fishStoreSection = new FishStoreSection();
        
        fishStoreSection.Products.Add(new Beverage("Salmon", 20, 10));
        fishStoreSection.Products.Add(new Beverage("f2", 44, 210));
        fishStoreSection.Products.Add(new Beverage("Jf3", 11, 130));
        fishStoreSection.Products.Add(new Beverage("f4r", 220, 150));
      
        var meatStoreSection = new MeatStoreSection();
        
        meatStoreSection.Products.Add(new Beverage("port", 20, 10));
        meatStoreSection.Products.Add(new Beverage("beef", 44, 210));
        meatStoreSection.Products.Add(new Beverage("lamb", 11, 130));
        meatStoreSection.Products.Add(new Beverage("chicken", 220, 150));
       
        var milkStoreSection = new MilkStoreSection();
        
        milkStoreSection.Products.Add(new Beverage("cheese", 20, 10));
        milkStoreSection.Products.Add(new Beverage("milk", 44, 210));
        milkStoreSection.Products.Add(new Beverage("butter", 11, 130));
        milkStoreSection.Products.Add(new Beverage("yougurt", 220, 150));
        
        var vegetablesStoreSection = new VegetablesStoreSection();
        
        vegetablesStoreSection.Products.Add(new Beverage("cucumber", 20, 10));
        vegetablesStoreSection.Products.Add(new Beverage("tomato", 44, 210));
        vegetablesStoreSection.Products.Add(new Beverage("cabbage", 11, 130));
        vegetablesStoreSection.Products.Add(new Beverage("onion", 220, 150));
        
        StoreSections.Add(vegetablesStoreSection);
        
    }
}