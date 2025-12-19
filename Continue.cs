class Killer
{
    public static void Print(int a)
    {
        for(int i = 1; i <= 10; i++)
        {
            if(i!=a)Console.WriteLine($"player {a} is killing {i}");
            else Console.WriteLine($"{a} is invisible skipping {a}");
        }
    }
}