using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
interface IGear
{
   public void gear1();
        void gear2();
   public  void gear3();
   public void gear4();
   public void gear5();
   public void gear6();
   

}
class Honda : IGear
{
   public  void  gear1()
    {
        Console.WriteLine("Gear 1 is tested");
    }
    public void gear2()
    {
        Console.WriteLine("Gear 2 is tested");
    } 
   public void gear3()
    {
        Console.WriteLine("Gear 3  is tested");
    }
    public void gear4()
    {
        Console.WriteLine("Gear 4 is tested");
    }
    public void gear5()
    {
        Console.WriteLine("Gear 5 is tested");
    }
    public void gear6()
    {
        Console.WriteLine("Gear  6 is tested");
    } 
}
abstract class Car
{
    public abstract void gear1();
    public abstract void engine();
    public abstract void drive();
}
class Audi : Car
{
    public override void gear1()
    {
        // throw new NotImplementedException();
        Console.WriteLine("In the gear1");
    }
    public override void engine()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Tested engine");
    }
    public override void drive()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Driving in the car");
    }
}
class Program
{
    public delegate int Add(int a,int b);
    public delegate int Subtract(int a,int b);
    public delegate int FindL(string a);


    static int sum(int a,int b)
    {
        return a+b;
    }
    static int minus(int a,int b)
    {
        return a-b;
    }
    static int L(string a)
    {
        return a.Length;
    }
    public static void Main()
    {

    //  Honda c1=new Honda()   ;
    //  c1.gear1();
        // List<int

        ///------------------->abstract<---------------------------
        // Car c=new Audi();
        // c.drive();
        // c.engine();
        // c.gear1();
        ///-------------------->Delegates<-------------------------
        // Console.WriteLine(Add(4,5));
        // Console.WriteLine(Subtract(4,5));
        // Console.wr
        Add a=sum;
        Subtract s=minus;
        FindL f=L;
        Console.WriteLine(a(4,5));
        Console.WriteLine(s(6,7));
        Console.WriteLine(f("bjhkj"));
    }
}