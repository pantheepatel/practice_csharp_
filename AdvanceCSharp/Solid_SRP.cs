using System;
using System.IO;
using System.Threading.Channels;

// The following class violates SRP because it has multiple responsibilities:Handling employee data (storing name and salary), Calculating tax, Saving employee details to a file
//public class Employee
//{
//    public string Name { get; set; }
//    public double Salary { get; set; }

//    public Employee(string name, double salary)
//    {
//        Name = name;
//        Salary = salary;
//    }

//    // Responsibility 1: Calculating tax (Business logic)
//    public double CalculateTax()
//    {
//        return Salary * 0.2; // 20% Tax
//    }

//    // Responsibility 2: Saving employee details (Persistence logic)
//    public void SaveToFile()
//    {
//        File.WriteAllText("employee.txt", $"{Name}, {Salary}");
//    }
//}


// Correct Approach: Applying SRP
// Employee class - Handles only employee-related data
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

// TaxCalculator class - Responsible for tax calculation
public class TaxCalculator
{
    public double CalculateTax(Employee employee)
    {
        return employee.Salary * 0.2; // 20% Tax
    }
}

// EmployeeRepository class - Responsible for persistence
public class EmployeeRepository
{
    public void SaveToFile(Employee employee)
    {
        File.WriteAllText("employee.txt", $"{employee.Name}, {employee.Salary}");
    }
}

//Benefits of SRP:
//Improved Maintainability: Changes in tax logic or storage won't affect the Employee class.
//Better Testability: We can test tax calculation and persistence separately.
//Loose Coupling: Each class has a single responsibility, making the codebase more modular.
