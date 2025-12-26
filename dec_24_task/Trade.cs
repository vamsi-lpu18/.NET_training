using System.Collections.Generic;

class Trade
{
    public int id { get; set; }
    public string Symbol { get; set; }
    public int q { get; set; }
}

class TradeRepository<T> where T : Trade
{
    public List<T> l = new List<T>();
    public static int total { get; private set; }

    public void Add(T trade)
    {
        l.Add(trade);
        total++;
    }
}
