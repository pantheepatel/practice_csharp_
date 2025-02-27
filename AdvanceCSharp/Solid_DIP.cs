//// not good approach

//// Low-level module (Direct dependency)
//public class GmailService
//{
//    public void SendEmail(string message)
//    {
//        Console.WriteLine($"Sending email via Gmail: {message}");
//    }
//}

//// High-level module (Dependent on low-level module)
//public class CustomerService
//{
//    private GmailService _emailService;

//    public CustomerService()
//    {
//        _emailService = new GmailService(); // Tight coupling
//    }

//    public void NotifyCustomer()
//    {
//        _emailService.SendEmail("Your order has been shipped!");
//    }
//}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        CustomerService customerService = new CustomerService();
//        customerService.NotifyCustomer();
//    }
//}

// better approach
// Step 1: Create an abstraction (interface)
public interface IEmailService
{
    void SendEmail(string message);
}

// Step 2: Implement different email services
public class GmailService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email via Gmail: {message}");
    }
}

public class OutlookService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email via Outlook: {message}");
    }
}

// Step 3: CustomerService now depends on abstraction, not concrete class
public class CustomerService
{
    private readonly IEmailService _emailService;

    // Dependency Injection (constructor injection)
    public CustomerService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void NotifyCustomer()
    {
        _emailService.SendEmail("Your order has been shipped!");
    }
}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        IEmailService emailService = new GmailService(); // Or new OutlookService();
//        CustomerService customerService = new CustomerService(emailService);
//        customerService.NotifyCustomer();
//    }
//}
