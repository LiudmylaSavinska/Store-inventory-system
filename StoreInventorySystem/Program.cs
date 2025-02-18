﻿using StoreInventorySystem;
using StoreInventorySystem.Implementations.Store;

var loginService = new LogInService();
var store = new Store();

Console.WriteLine("Welcome to the Store Inventory System");

var systemRunning = true;
while (systemRunning)
{
    Console.WriteLine("Enter your choice: \n 1. Log in, \n 2. Sign in, \n 3. Leave");
    
    var userOption = Console.ReadLine();

    switch (userOption)
    {
        case "1":
            if (loginService.LogIn())
            {
                ShowStoreMenu();
            }

            break;

        case "2":
            if (loginService.SignIn())
            {
                ShowStoreMenu();
            }

            break;

        case "3":
            Console.WriteLine("Have a nice day, bye!");
            systemRunning = false;
            break;

        default:
            Console.WriteLine("Please, select a valid option");
            break;
    }
}

void ShowStoreMenu()
{
    var inStore = true;
    
    Console.WriteLine("You are in!");
    
    
    while (inStore)
    {
        Console.WriteLine("Enter your choice: \n 1. Add product, \n 2. Remove product, \n 3. Get full list," + 
                          "\n 4. Get section list \n 5. Log Out");
        var menuOption = Console.ReadLine();
        
        switch (menuOption)
        {
            case "1":
                Console.WriteLine("Please enter product name, product section, " +
                                  "product price and product quantity");
               
                string productToAddName, productToAddSection;
                double productPrice;
                int productQuantity;

                productToAddName = Console.ReadLine();
                productToAddSection = Console.ReadLine();
                productPrice = Convert.ToDouble(Console.ReadLine());
                productQuantity = Convert.ToInt32(Console.ReadLine());
                
                store.AddProduct(productToAddName, productToAddSection, productPrice, productQuantity);
                break;

            case "2":
                Console.WriteLine("Please enter product name, product section");
               
                string productName, productSection;
                productName = Console.ReadLine();
                productSection = Console.ReadLine();

                store.RemoveProduct(productName, productSection);
                break;

            case "3":
                store.GetFullList();
                break;

            case "4":
                Console.WriteLine("Please enter section name");
                string sectionToView = Console.ReadLine();
                Console.WriteLine(store.GetSectionList(sectionToView));
                break;
            
            case "5":
                Console.WriteLine("Have a nice day, bye!");
                inStore = false;
                break;

            default:
                Console.WriteLine("Please, select a valid option");
                break;
        }
    }
}