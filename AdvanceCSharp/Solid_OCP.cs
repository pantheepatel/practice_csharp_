using System;

//// This violates OCP because we modify existing code instead of extending it. It increases maintenance effort and potential bugs.
//public class Invoice
//{
//    public double Amount { get; set; }
//    public string CustomerType { get; set; } // "Regular" or "Premium" only

//    public Invoice(double amount, string customerType)
//    {
//        Amount = amount;
//        CustomerType = customerType;
//    }

//    public double GetDiscount()
//    {
//        if (CustomerType == "Regular")
//        {
//            return Amount * 0.1;
//        }
//        else if (CustomerType == "Premium")
//        {
//            return Amount * 0.2;
//        }
//        return 0;
//    }
//}

// better approach
// Step 1: Create an interface for discount strategy
public interface IDiscount
{
    double ApplyDiscount(double amount);
}

// Step 2: Implement different discount strategies
public class RegularDiscount : IDiscount
{
    public double ApplyDiscount(double amount) => amount * 0.1;
}

public class PremiumDiscount : IDiscount
{
    public double ApplyDiscount(double amount) => amount * 0.2;
}

// Step 3: Invoice class follows OCP (It does not change when we add new discounts)
public class Invoice
{
    public double Amount { get; set; }
    private readonly IDiscount _discountStrategy;

    public Invoice(double amount, IDiscount discountStrategy)
    {
        Amount = amount;
        _discountStrategy = discountStrategy;
    }

    public double GetDiscount() => _discountStrategy.ApplyDiscount(Amount);
}

//// Usage
//class Program
//{
//    static void Main()
//    {
//        Invoice regularInvoice = new Invoice(1000, new RegularDiscount());
//        Console.WriteLine("Regular Customer Discount: " + regularInvoice.GetDiscount());

//        Invoice premiumInvoice = new Invoice(1000, new PremiumDiscount());
//        Console.WriteLine("Premium Customer Discount: " + premiumInvoice.GetDiscount());
//    }
//}
