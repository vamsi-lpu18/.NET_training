struct StockPrice
{
    public string Symbol;
    public int price;
};
class Trade
{
    public int trade_id;
    public string Symbol;
    public int quantity;
}
class Portfolio
{
    public string Name;

    public override bool Equals(object obj)
    {
        Portfolio p = obj as Portfolio;
        return p != null && p.Name == Name;
    }
     public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

class Trades { }

class EquityTrade : Trades { } 
/// <summary>
///  generic class
/// </summary>
/// <typeparam name="T"></typeparam>
class Repos<T> where T : class
{
    public T data;
}

/// <summary>
/// Generic Methods
/// </summary>
class Calculator
{
    public T calc<T>(T a,T b)
    {
        return a;
    }
}
class Program
{
    public static void Main(){
    // StockPrice sp=new StockPrice
    // {
    //     Symbol="AApl",
    //     price=3000
    // };
    // StockPrice copy_address=sp;
    // copy_address.price=4000;
    // Console.WriteLine(copy_address.price+","+sp.price);
    // Trade td=new Trade
    // {
    //     trade_id=212,Symbol="AAPPEE",quantity=600
    // };
    // Trade ctd=td;
    // ctd.trade_id=300;
    // Console.WriteLine(td.trade_id+","+ctd.trade_id);
    Portfolio p1 = new Portfolio { Name = "Growth" };
        Portfolio p2 = new Portfolio { Name = "Growth2" };
        Portfolio p3=p2;
        // Console.WriteLine(p3==p2);

        // Console.WriteLine(p1.Equals(p2));
        // Console.WriteLine(p1==p2);
        // Console.WriteLine(p1.GetHashCode());
        // Console.WriteLine(p2.GetHashCode());
        //  Trades t = new EquityTrade();
        // Console.WriteLine(t.GetType());
        /// generic  class
        // Repos<Trade> traderepo=new Repos<Trade>() ;
        // traderepo.data=new Trade{trade_id=1212,Symbol="AAPLF",quantity=300};
        // Console.WriteLine(traderepo.data.trade_id+" "+traderepo.data.Symbol+" "+traderepo.data.quantity);
        ///!SECTION
        /// Generic Methods
        Calculator c=new Calculator();
        Console.WriteLine(c.calc(2,3));
        // double res=c.calc(343.4545,34.4545);
        Console.WriteLine(c.calc("asdad",3434));


        /// generic COllection
        List<T> l=new List<T>();
        l.Add(10);
        l.Add(30.6);
        foreach(a<T> in l)
        {
            
        }
    }

}
