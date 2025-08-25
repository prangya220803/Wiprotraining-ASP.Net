// WITHOUT SRP

//using System;

//public class User
//{
//    public string Username { get; set; }
//    public string Email { get; set; }

//    public void SaveUserToDatabase()
//    {
//        Console.WriteLine($"Saving user {Username} to database.");
//    }

//    public void SendWelcomeEmail()
//    {
//        Console.WriteLine($"Sending welcome email to {Email}.");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        User user = new User
//        {
//            Username = "prangya",
//            Email = "prangyaparamita@gmail.com"
//        };

//        user.SaveUserToDatabase();
//        user.SendWelcomeEmail();
//    }
//}

//-----------------------------------------------------------------------------------------------------------

// WITH SRP

//using System;

//public class User
//{
//    public string Username { get; set; }
//    public string Email { get; set; }
//}

//public class UserRepository
//{
//    public void Save(User user)
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
//    public static void Main()
//    {
//        User user = new User
//        {
//            Username = "prangya",
//            Email = "prangyaparamita@gmail.com"
//        };

//        UserRepository userRepository = new UserRepository();
//        EmailService emailService = new EmailService();

//        userRepository.Save(user);
//        emailService.SendWelcomeEmail(user);
//    }
//}