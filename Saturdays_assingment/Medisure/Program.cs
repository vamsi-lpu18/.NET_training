// using System.Reflection.PortableExecutable;

// class PatientBill
// {
//     public string pn,bid;
//     public bool hasInsurance=false;
//     public double cf,lc,mc,ga,da,fp;
//     public static PatientBill LastBill;
//     public static bool hasLastBill;
//     public double GrossAmount;
//     public string BID
//     {
//         get
//         {
//             return bid;
//         }
//         set
//         {
//             if (value.Length > 0)
//             {
//                 bid=value;
//             }
//         }
//     }
//     public double CF
//     {
//         get
//         {
//             return cf;
//         }
//         set
//         {
//             if (value > 0)
//             {
//                 cf=value;
//             }
//         }
//     }
//     public double LC
//     {
//         get
//         {
//             return lc;
//         }
//         set
//         {
//             if (value > 0)
//             {
//                 lc=value;
//             }
//         }
//     }
//     public double MC
//     {
//         get
//         {
//             return mc;
//         }
//         set
//         {
//             if (value >= 0)
//             {
//                 mc=value;
//             }
//         }
//     }
//     public double Discount()
//     {
//         // if (hasInsurance)
//         // {
//             double total= CF + LC+MC;
//         // }
//         GrossAmount=total;
//         if (hasInsurance)
//         {
//             return total-total*0.10;
//         }else return total;
        
//     } 
//     public double FinalPayable()
//     {
//         return GrossAmount-Discount();
//     }

    
// }
// class Program
// {
//     public static void lastBill()
//     {
//         Console.WriteLine($"BillID: {PatientBill.LastBill.BID}");
//         Console.WriteLine($"Patient: {PatientBill.LastBill.Pn}");
//         Console.WriteLine($"Insured: {PatientBill.LastBill.hasInsurance}");
//         Console.WriteLine($"Consultation Fee: {PatientBill.LastBill.CF}");
//         Console.WriteLine($"Lab charge: {PatientBill.LastBill.LC}");
//         Console.WriteLine($"Medicine charges: {PatientBill.LastBill.MC}");
//         Console.WriteLine($"Gross Amount: {PatientBill.LastBill.GrossAmount}");
//         Console.WriteLine($"Final Payable: {PatientBill.LastBill.FinalPayable()}");
//     }
//     public static void createuser()
//     {
//         Console.WriteLine("Enter BillId: ");
//         string f=Console.ReadLine();
//         Console.WriteLine("Patient Name: ");
//         string n=Console.ReadLine();
//         Console.WriteLine("HasInsurance Y/N :");
//         string flag=Console.ReadLine();
//         bool hasi=(flag=="Y")?true:false;
//         Console.WriteLine("Consultation Fee : ");
//         double cf=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("LabCharges : ");
//         double lc=Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Medicine Charges : ");
//         double mc=Convert.ToDouble(Console.ReadLine());
//         PatientBill.hasLastBill=true;
//         PatientBill pb=new PatientBill
//         {
//             BID=f,pn=n,hasInsurance=hasi,CF=cf,LC=lc,MC=mc
//         };
//         PatientBill.LastBill=pb;
//     }
//     public static void Main()
//     {
//         Console.WriteLine("1. Create New Bill (Enter Patient Details)");
//         Console.WriteLine("2. View Last Bill");
//         Console.WriteLine("3. Clear Last Bill");
//         Console.WriteLine("4. Exit");
//         while (true)
//         {
//             int n=Convert.ToInt32(Console.ReadLine());
//             if(n==4)
//             break;
//             else if (n == 1)
//             {
//                 createuser();
//             }else if (n == 2)
//             {
//                 lastBill();
//             }else if (n == 3)
//             {
//                 PatientBill.hasLastBill=false;
//                 PatientBill.LastBill=null;
//             }
//         }
//     }
// }
using System;

class PatientBill
{
    public string pn, bid;
    public bool hasInsurance = false;
    public double cf, lc, mc;
    public static PatientBill LastBill;
    public static bool hasLastBill;
    public double GrossAmount;

    public string BID
    {
        get { return bid; }
        set { if (value.Length > 0) bid = value; }
    }

    public string Pn
    {
        get { return pn; }
        set { if (value.Length > 0) pn = value; }
    }

    public double CF
    {
        get { return cf; }
        set { if (value > 0) cf = value; }
    }

    public double LC
    {
        get { return lc; }
        set { if (value > 0) lc = value; }
    }

    public double MC
    {
        get { return mc; }
        set { if (value >= 0) mc = value; }
    }

    public double Discount()
    {
        GrossAmount = CF + LC + MC;
        return hasInsurance ? GrossAmount * 0.10 : 0;
    }

    public double FinalPayable()
    {
        return GrossAmount - Discount();
    }
}

class Program
{
    public static void lastBill()
    {
        if (!PatientBill.hasLastBill)
        {
            Console.WriteLine("No bill available.");
            return;
        }

        Console.WriteLine($"BillID: {PatientBill.LastBill.BID}");
        Console.WriteLine($"Patient: {PatientBill.LastBill.Pn}");
        Console.WriteLine($"Insured: {PatientBill.LastBill.hasInsurance}");
        Console.WriteLine($"Consultation Fee: {PatientBill.LastBill.CF}");
        Console.WriteLine($"Lab charge: {PatientBill.LastBill.LC}");
        Console.WriteLine($"Medicine charges: {PatientBill.LastBill.MC}");
        Console.WriteLine($"Gross Amount: {PatientBill.LastBill.GrossAmount}");
        Console.WriteLine($"Final Payable: {PatientBill.LastBill.FinalPayable()}");
    }

    public static void createuser()
    {
        Console.WriteLine("Enter BillId:");
        string f = Console.ReadLine();

        Console.WriteLine("Patient Name:");
        string n = Console.ReadLine();

        Console.WriteLine("Has Insurance (Y/N):");
        bool hasi = Console.ReadLine().ToUpper() == "Y";

        Console.WriteLine("Consultation Fee:");
        double cf = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lab Charges:");
        double lc = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Medicine Charges:");
        double mc = Convert.ToDouble(Console.ReadLine());

        PatientBill pb = new PatientBill
        {
            BID = f,
            Pn = n,
            hasInsurance = hasi,
            CF = cf,
            LC = lc,
            MC = mc
        };

        PatientBill.LastBill = pb;
        PatientBill.hasLastBill = true;
        Console.WriteLine("User created successfully");
    }

    public static void Main()
    {
        Console.WriteLine("1. Create New Bill");
        Console.WriteLine("2. View Last Bill");
        Console.WriteLine("3. Clear Last Bill");
        Console.WriteLine("4. Exit");

        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 4)
                break;
            else if (n == 1)
                createuser();
            else if (n == 2)
                lastBill();
            else if (n == 3)
            {
                PatientBill.LastBill = null;
                PatientBill.hasLastBill = false;
            }
        }
    }
}
