namespace StoreInventorySystem;

public class LogInService
{
    private Dictionary<string, string> userAccounts;

    public LogInService()
    {
        userAccounts = new Dictionary<string, string>();
    }

    public bool SignIn()
    {
        Console.WriteLine("Please, enter your name");
        var userNickname = Console.ReadLine();

        if (userAccounts.ContainsKey(userNickname))
        {
            Console.WriteLine("Your account already exists");
            return false;
        }
        else
        {
            Console.WriteLine("Please, enter your password");
            var userPassword = Console.ReadLine();

            userAccounts.Add(userNickname, userPassword);
            Console.WriteLine("Thank you for your registration!");
            return true;
        }
    }

    public bool LogIn()
    {
        Console.WriteLine("Please, enter your name");
        var userNickname = Console.ReadLine();

        Console.WriteLine("Please, enter your password");
        var userPassword = Console.ReadLine();

        if (userAccounts.ContainsKey(userNickname) && userAccounts[userNickname] == userPassword)
        {
            Console.WriteLine("You have successfully logged in!");
            return true;
        }
            
        Console.WriteLine("Please, enter valid credentials or sign in");
        return false;
    }
}