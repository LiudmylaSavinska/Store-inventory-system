namespace StoreInventorySystem.Implementations;

public class LogInMenu
{
   public void ShowMenu()
   {
      Console.WriteLine("Welcome to the Store Inventory System" +
                        "Enter your choice: \n Log in, \n Sign in, \n Leave\"");
      
      var userOption = Console.ReadLine();
      
      switch (userOption)
      {
         case "Log in":
            LogIn();
            break;

         case "Sign in":
            SignIn();
            break;

         case "Leave":
            Console.WriteLine("Have a nice day, bye!");
            break;

         default:
            Console.WriteLine("Please, select a valid option");
            break;
      }
   }
   
   Dictionary<string, string> userAccounts = new Dictionary<string, string>();
   
   public void SignIn()
   {
      var validNickname = false;
      while (!validNickname)
      {
         Console.WriteLine("Please, enter your name");
         var userNickname = Console.ReadLine();
         
         if (userAccounts.ContainsKey(userNickname))
         {
            Console.WriteLine("Your account already exists");
         }
         else
         {
            Console.WriteLine("Please, enter your password");
            var userPassword = Console.ReadLine();

            userAccounts.Add(userNickname, userPassword);
            Console.WriteLine("Thank you for your registration!");
            validNickname = true;
         }
         
      }
   }
   public void LogIn()
   {
      var correctCredentials = false;
      while (!correctCredentials)
      {
         Console.WriteLine("Please, enter your name");
         var userNickname = Console.ReadLine();

         Console.WriteLine("Please, enter your password");
         var userPassword = Console.ReadLine();
         
         if (userAccounts[userNickname] == userAccounts[userPassword])
         {
            Console.WriteLine("You have successfully logged in!");
            correctCredentials = true;
         }
         else
         {
            Console.WriteLine("Please, enter valid credentials or sign in");
         }
      }
   } 
}