// struct PriceSnapshot
// {
//     public string Symbol;
//     public int price;

// }
using System.Dynamic;

// abstract class Trade
// {
//     public int id{get; set;}
//     public string Symbol{get;set;}
//     public int q{get;set;}
//     public double?market{get;set;}
//     public abstract double Calculate();
//     public abstract double CalculateTrade();
//     public override string ToString()
//     {
//         return $"the id of trade is :{id} its symbol is {Symbol} with quantity is {q}";
//         // return base.ToString();
//     }

// }
// class Equity : Trade
// {
//     public int price
//     {
//         get;set;
//     }
//     public override double Calculate()
//     {
//         return price*q;
//     }
//     public override double CalculateTrade()
//     {
//         // throw new NotImplementedException();
//         return q * (market ?? 0);
//     }
// }
// class EquityTrade : Trade
// {
//     public int mprice;
// }
class Program
{
    public static void Main()
    {
        ///!SECTION task-1
        // PriceSnapshot p=new PriceSnapshot
        // {
        //     Symbol="AAPL",price=344
        // };
        // Console.WriteLine(p.Symbol+" "+p.price);

        ///!SECTION task -2
        /// 
        // Trade t=new Equity
        // {
        //     id=100,
        //     Symbol="AAAA",q=4,
        //     price=233
        // };
        // double res=t.CalculateTrade();
        // Console.WriteLine(res);


        ///!SECTIONtask-3
        /// 
        //   Trade t=new Equity
        // {
        //     id=100,
        //     Symbol="AAAA",q=4,
        //     price=233,market=40
        // };
        // double res=t.CalculateTrade();
        // Console.WriteLine(res);
        /// task-4
        // TradeRepository<Trade> rep=new TradeRepository<Trade>();
        // rep.Add(new Trade
        // {
        //     id=3434,
        //     Symbol="EFSADF",q=56
        // });
        //  rep.Add(new Trade
        // {
        //     id=3434323,
        //     Symbol="DSDSDSADF",q=434
        // });
        //  rep.Add(new Trade
        // {
        //     id=356670904,
        //     Symbol="erererEFSADF",q=4456
        // });
        // Console.WriteLine(TradeRepository<Trade>.total);

        ///  task-5
        /// 
    }

}