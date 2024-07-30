namespace StoreInventorySystem;

public class LogInService
{
   private Dictionary<string, string> userAccounts;

   public LogInService()
   {
      userAccounts = new Dictionary<string, string>();
   }
   
   
   
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
         
         if (userAccounts[userNickname] == userPassword)
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