// using System;

class Tables
{
    public static void Print(int a)
    {
        for(int i = 1; i <= a; i++)
        {
            Console.WriteLine($"Table of {i}:-");
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j} ");
            }
        }
    }
}