abstract class Employee
{
    public abstract double getPay();
}
class HourlyEmployee : Employee
{
    public double h{get;set;}
    public double r{get;set;}
    public HourlyEmployee(double H,double R)
    {
        h=H;
        r=R;
    }
    public override double getPay()
    {
        return h*r;
    }
}
class SalariedEmployee : Employee
{
    public double salary{get;set;}
    public SalariedEmployee(double s)
    {
        salary=s;
    }
    public override double getPay()
    {
        return salary;
    }
}
class CommissionEmployee : Employee
{
    public double baseSalary{get;set;}
    public double commission{get;set;}
    public CommissionEmployee(double b,double c)
    {
        baseSalary=b;
        commission=c;
    }
    public override double getPay()
    {
        return baseSalary+commission;
    }
}
class Program
{
    
    public static void Main()
    {
        List<string>emp=new List<string>
    {
        "H 256 500","S 300000" , "C 150000 250000"
    };
    double totalPay=0;
    foreach(string t in emp)
        {
           var ele =t.Split(" ");
            switch (ele[0])
            {
                case "H":
                    {
                        HourlyEmployee hemp=new HourlyEmployee(Convert.ToDouble(ele[1]),Convert.ToDouble(ele[2]));
                        totalPay+=hemp.getPay();
                    }
                    continue;
                    case "S":
                    {
                        SalariedEmployee semp=new SalariedEmployee(Convert.ToDouble(ele[1]));
                    }
                    continue;
                    case "C":
                    {
                        CommissionEmployee cemp=new CommissionEmployee(Convert.ToDouble(ele[1]),Convert.ToDouble(ele[2]));
                    }
                    continue;
            }
        }
        Console.WriteLine("Total pays "+totalPay);
    }
}