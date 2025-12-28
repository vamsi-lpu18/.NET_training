using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Runtime.InteropServices;

class SaleTransaction
{
    // static storage
    public static SaleTransaction last;
    public static bool hasLast = false;

    // private fields
    private string _in;
    private string _cn;
    private string _itn;
    private int _q;
    private double _pa;
    private double _sa;

    // properties with validation
    public string IN
    {
        get { return _in; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Invoice cannot be empty");
            _in = value;
        }
    }

    public string CN
    {
        get { return _cn; }
        set { _cn = value; }
    }

    public string ITN
    {
        get { return _itn; }
        set { _itn = value; }
    }

    public int Q
    {
        get { return _q; }
        set
        {
            if (value <= 0)
                throw new Exception("Quantity must be > 0");
            _q = value;
        }
    }

    public double PA
    {
        get { return _pa; }
        set
        {
            if (value <= 0)
                throw new Exception("Purchase amount must be > 0");
            _pa = value;
        }
    }

    public double SA
    {
        get { return _sa; }
        set
        {
            if (value < 0)
                throw new Exception("Selling amount cannot be negative");
            _sa = value;
        }
    }

    public double ProfitLossAmount => SA - PA;

    public string ProfitStatus
    {
        get
        {
            if (SA > PA) return "PROFIT";
            if (SA < PA) return "LOSS";
            return "BREAK-EVEN";
        }
    }
}

   class Program
{
    public static void Createuser()
    {
        SaleTransaction s = new SaleTransaction();

        Console.Write("Enter invoiceNo: ");
        s.IN = Console.ReadLine();

        Console.Write("Enter Customer Name: ");
        s.CN = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        s.ITN = Console.ReadLine();

        Console.Write("Enter Purchase Amount: ");
        s.PA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Selling Amount: ");
        s.SA = Convert.ToDouble(Console.ReadLine());

        SaleTransaction.last = s;
        SaleTransaction.hasLast = true;

        Console.WriteLine("Transaction created successfully.");
    }

    public static void Display()
    {
        if (!SaleTransaction.hasLast)
        {
            Console.WriteLine("No transaction available");
            return;
        }

        var t = SaleTransaction.last;

        Console.WriteLine("\nLast Transaction Details:");
        Console.WriteLine($"InvoiceNo: {t.IN}");
        Console.WriteLine($"Customer: {t.CN}");
        Console.WriteLine($"Item: {t.ITN}");
        Console.WriteLine($"Purchase Amount: {t.PA}");
        Console.WriteLine($"Selling Amount: {t.SA}");
        Console.WriteLine($"Status: {t.ProfitStatus}");
        Console.WriteLine($"Profit/Loss Amount: {t.ProfitLossAmount}");
    }

    public static void calculate()
    {
        if (!SaleTransaction.hasLast)
        {
            Console.WriteLine("No transaction available");
            return;
        }

        double res = SaleTransaction.last.SA - SaleTransaction.last.PA;

        if (res > 0)
            Console.WriteLine($"Profit : {res}");
        else if (res < 0)
            Console.WriteLine($"Loss : {res}");
        else
            Console.WriteLine("Break Even");
    }

    public static void Main()
    {
        Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
        Console.WriteLine("2. View Last Transaction");
        Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
        Console.WriteLine("4. Exit");

        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 4) break;
            else if (n == 1) Createuser();
            else if (n == 2) Display();
            else if (n == 3) calculate();
            else Console.WriteLine("Invalid choice");
        }
    }
}
