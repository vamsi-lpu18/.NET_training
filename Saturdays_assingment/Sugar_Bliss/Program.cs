using System.Dynamic;
using System.Security.Principal;

class Chocolate
{
    public string flavour{get;set;}
    public int Quantity{get;set;}
    public int PricePerUnit{get;set;}
    public double TotalPrice{get;set;}
    public double DiscountedPrice{get;set;}
    public bool ValidateChocolateFlavour()
    {
       if(flavour=="Dark" || flavour=="Milk" || flavour=="White")
       return true;
       return false;
    }
}
class Program
{
    public static Chocolate calculateDiscountedPrice( Chocolate chocolate)
    {
        double dis=0;
        if (chocolate.flavour == "Dark")
        {
            chocolate.DiscountedPrice=0.18;
        }else if(chocolate.flavour=="Milk")
        chocolate.DiscountedPrice=0.12;
        else
        {
            chocolate.DiscountedPrice=0.06;
        }
        chocolate.TotalPrice=chocolate.Quantity*chocolate.PricePerUnit;
        chocolate.DiscountedPrice=chocolate.TotalPrice-chocolate.TotalPrice*chocolate.DiscountedPrice;
        // chocolate.total=dtotal;
        // chocolate
        return chocolate;
    }
    public static void Main()
    {
        Console.WriteLine("Enter your flavour :");
        string fla=Console.ReadLine();
        Console.WriteLine("Enter Quantity: ");
        int res=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Price per Unit");
        int price=Convert.ToInt32(Console.ReadLine());
        Chocolate chocolate=new Chocolate
        {
            flavour=fla,Quantity=res,PricePerUnit=price
        };
        if (chocolate.ValidateChocolateFlavour())
        {
           
        //    calculateD
        calculateDiscountedPrice(chocolate);
        Console.WriteLine($"Flavour : {chocolate.flavour} Quantity : {chocolate.Quantity}");
        Console.WriteLine($"Price per unit : {chocolate.PricePerUnit} Total price {chocolate.TotalPrice}");
        Console.WriteLine($"Discounted Price : {chocolate.DiscountedPrice}");
        }
    }
}