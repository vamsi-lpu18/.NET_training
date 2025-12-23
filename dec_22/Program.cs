using System;
class Persons
{
    public string Name;

    public Persons(string name)
    {
        Name = name;
    }
}

class Studente : Persons
{
    public int RollNo;

    public Studente(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}
// using System;
// using System.Collections.Generic;
// using System.Linq;

// #region 1. Sealed Security Module
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticated successfully");
        Console.WriteLine();
    }
}
// #endregion

// #region 2. Abstract Base Class
abstract class InsurancePolicy
{
    public int PolicyNumber { get; init; }

    private double premium;
    public double Premium
    {
        get { return premium; }
        protected set
        {
            if (value <= 0)
                throw new ArgumentException("Premium must be greater than zero");
            premium = value;
        }
    }

    public string PolicyHolder { get; set; }

    public virtual double CalculatePremium()
    {
        return Premium;
    }

    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}

class LifeInsurance : InsurancePolicy
{
    public LifeInsurance(int number, string holder, double premium)
    {
        PolicyNumber = number;
        PolicyHolder = holder;
        Premium = premium;
    }

    public override double CalculatePremium()
    {
        return Premium + 500;
    }

    // Method Hiding
    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}
// #endregion

// #region 3b. Health Insurance
class HealthInsurance : InsurancePolicy
{
    public HealthInsurance(int number, string holder, double premium)
    {
        PolicyNumber = number;
        PolicyHolder = holder;
        Premium = premium;
    }

    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}
// #endregion

// #region 4. Policy Directory with Indexers
class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();

    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }

    public InsurancePolicy this[int index]
    {
        get { return policies[index]; }
    }

    public InsurancePolicy this[string name]
    {
        get { return policies.First(p => p.PolicyHolder == name); }
    }
}
// #endregion

// #region 5. Main Program
// class Program
// {
    // static void Main()
    // {
    //     // Authentication
    //     Security security = new Security();
    //     security.Authenticate();

    //     // Policies
    //     InsurancePolicy life = new LifeInsurance(101, "Amit", 5000);
    //     InsurancePolicy health = new HealthInsurance(102, "Neha", 7000);

    //     // Directory
    //     PolicyDirectory directory = new PolicyDirectory();
    //     directory.AddPolicy(life);
    //     directory.AddPolicy(health);

    //     // Indexer usage
    //     Console.WriteLine(directory[0].PolicyHolder);
    //     Console.WriteLine(directory["Neha"].PolicyNumber);

    //     // Runtime Polymorphism
    //     Console.WriteLine("Life Premium: " + life.CalculatePremium());
    //     Console.WriteLine("Health Premium: " + health.CalculatePremium());

    //     // Method hiding demonstration
    //     LifeInsurance lifeRef = new LifeInsurance(103, "Raj", 4000);
    //     lifeRef.ShowPolicy();

    //     InsurancePolicy baseRef = lifeRef;
    //     baseRef.ShowPolicy();
    // }
// }
// #endregion

// class Bank
// {
//     protected int balance;
//     protected int ac;

//     public Bank(int balance, int ac)
//     {
//         this.balance = balance;
//         this.ac = ac;
//     }

//     public void ShowBank()
//     {
//         Console.WriteLine("Account Number: " + ac);
//         Console.WriteLine("Balance: " + balance);
//     }
// }

// class Fixed_depo : Bank
// {
//     int timeperiod;
//     double roi;
//     double fd_amount;

//     public Fixed_depo(int balance, int ac, int timeperiod, double roi, double fd_amount)
//         : base(balance, ac)
//     {
//         this.timeperiod = timeperiod;
//         this.roi = roi;
//         this.fd_amount = fd_amount;
//     }

//     public double CalculateMaturityAmount()
//     {
//         return fd_amount + (fd_amount * roi * timeperiod) / 100;
//     }

//     public void DisplayDetails()
//     {
//         ShowBank();
//         Console.WriteLine("FD Amount: " + fd_amount);
//         Console.WriteLine("Time Period (years): " + timeperiod);
//         Console.WriteLine("Rate of Interest: " + roi + "%");
//         Console.WriteLine("Maturity Amount: " + CalculateMaturityAmount());
//     }
// }

// class Student
// {
//     static string collegeName;
//     static int totalStudents;

//     // Static constructor
//     static Student()
//     {
//         collegeName = "BITS Hyderabad";
//         totalStudents = 0;
//         Console.WriteLine("Static constructor called");
//     }

//     int rollNo;
//     string name;

//     public Student(int rollNo, string name)
//     {
//         this.rollNo = rollNo;
//         this.name = name;
//         totalStudents++;
//         Console.WriteLine("Instance constructor called");
//     }

//     public void Display()
//     {
//         Console.WriteLine("Roll No: " + rollNo);
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("College: " + collegeName);
//         Console.WriteLine("Total Students: " + totalStudents);
//     }
// }

class Program
{
    static void Main()
    {
//         Fixed_depo fd = new Fixed_depo(50000, 123456, 3, 6.5, 100000);
//         fd.DisplayDetails();

//         Console.WriteLine();

//         Student s1 = new Student(1, "Vamsi");
//         s1.Display();

//         Console.WriteLine();

//         Student s2 = new Student(2, "Rahul");
//         s2.Display();
//         Product p = new Product
// {
//     Name = "Laptop",
//     Price = 50000
// };
//  StudentExtended s = new StudentExtended("REG2024A")
//         {
//             StudentId = 101,
//             AdmissionYear = 2024
//         };

//         // Assigning allowed properties
//         s.Name = "Vamsi";
//         s.Age = 21;
//         s.Marks = 85;
//         s.Password = "secure123";

        // Display readable properties
        // Console.WriteLine("Student ID: " + s.StudentId);
        // Console.WriteLine("Registration No: " + s.RegistrationNumber);
        // Console.WriteLine("Admission Year: " + s.AdmissionYear);
        // Console.WriteLine("Name: " + s.Name);
        // Console.WriteLine("Age: " + s.Age);
        // Console.WriteLine("Marks: " + s.Marks);
        // Console.WriteLine("Result: " + s.Result);
        // Console.WriteLine("Percentage: " + s.Percentage);
        // Library l=new Library();
        // l[1]=".Net tutorials";
        // l[2]="C# tutorials";
        // l[3]="React tutorials";
        // Console.WriteLine($"the courses that i have learned : {l[1]} , {l[2]}, {l[3]}");

    Studente e=new Studente("vamsi",90);
     Security security = new Security();
        security.Authenticate();

        // Policies
        InsurancePolicy life = new LifeInsurance(101, "Amit", 5000);
        InsurancePolicy health = new HealthInsurance(102, "Neha", 7000);

        // Directory
        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);

        // Indexer usage
        Console.WriteLine(directory[0].PolicyHolder);
        Console.WriteLine(directory["Neha"].PolicyNumber);

        // Runtime Polymorphism
        Console.WriteLine("Life Premium: " + life.CalculatePremium());
        Console.WriteLine("Health Premium: " + health.CalculatePremium());

        // Method hiding demonstration
        LifeInsurance lifeRef = new LifeInsurance(103, "Raj", 4000);
        lifeRef.ShowPolicy();

        InsurancePolicy baseRef = lifeRef;
        baseRef.ShowPolicy();

    Console.WriteLine(e.Name);
    }
}
