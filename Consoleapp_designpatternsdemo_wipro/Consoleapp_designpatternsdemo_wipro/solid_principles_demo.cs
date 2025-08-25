using System;
public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public void SaveUserToDatabase()
    {
        Console.WriteLine($"Saving user {Username} to database.");
    }
    public void SendWelcomeEmail()
    {
        Console.WriteLine($"Sending welcome email to {Email}.");
    }
}


//public class User
//{
//    public string Username { get; set; }
//    public string Email { get; set; }
//}


//public class UserRepository
//{
//    public void SaveUserToDatabase(User user)
//    {
//        Console.WriteLine($"Saving user {user.Username} to database.");
        
//    }
//}


//public class EmailService
//{
//    public void SendWelcomeEmail(User user)
//    {
//        Console.WriteLine($"Sending welcome email to {user.Email}.");
       
//    }
//}


//public class Program
//{
//    public static void Main(string[] args)
//    {
        
//        User newUser = new User
//        {
//            Username = "john_doe",
//            Email = "john.doe@example.com"
//        };

        
//        UserRepository userRepository = new UserRepository();
//        userRepository.SaveUserToDatabase(newUser);

        
//        EmailService emailService = new EmailService();
//        emailService.SendWelcomeEmail(newUser);

//        Console.WriteLine("\nProgram execution completed following SRP.");
//        Console.ReadKey(); 
//    }
//}
