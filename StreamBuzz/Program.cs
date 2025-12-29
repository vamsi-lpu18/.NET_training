
using System;
using System.Collections.Generic;
using System.Linq;

class CreatorStats
{
    public string CreatorName;
    public double[] WeeklyLikes;
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
}

class Program
{
    public static void RegisterCreator()
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();

        double[] likes = new double[4];
        Console.WriteLine("Enter 4 Weekly likes:");
        for (int i = 0; i < 4; i++)
        {
            likes[i] = Convert.ToDouble(Console.ReadLine());
        }

        CreatorStats cs = new CreatorStats
        {
            CreatorName = name,
            WeeklyLikes = likes
        };

        CreatorStats.EngagementBoard.Add(cs);
        Console.WriteLine("User registered successfully");
    }

    public static Dictionary<string, double> GetTopPostCounts(double likeThreshold)
    {
        Dictionary<string, double> dict = new Dictionary<string, double>();

        foreach (CreatorStats cs in CreatorStats.EngagementBoard)
        {
            double sum = 0;
            foreach (double d in cs.WeeklyLikes)
                sum += d;

            if (sum >= likeThreshold)
                dict[cs.CreatorName] = sum;
        }

        return dict
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);
    }

    public static double CalculateAverageLikes()
    {
        double total = 0;
        int count = 0;

        foreach (CreatorStats cs in CreatorStats.EngagementBoard)
        {
            foreach (double d in cs.WeeklyLikes)
            {
                total += d;
                count++;
            }
        }

        return count == 0 ? 0 : total / count;
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Enter threshold");
            Console.WriteLine("3. Overall average weekly likes");
            Console.WriteLine("4. Logging Off......");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 4)
                break;
            else if (n == 1)
            {
                RegisterCreator();
            }
            else if (n == 2)
            {
                Console.WriteLine("Enter like threshold:");
                double t = Convert.ToDouble(Console.ReadLine());

                var result = GetTopPostCounts(t);
                foreach (var r in result)
                    Console.WriteLine($"{r.Key} : {r.Value}");
            }
            else if (n == 3)
            {
                Console.WriteLine("Average Likes: " + CalculateAverageLikes());
            }
            else
            {
                Console.WriteLine("Enter a valid number between 1-4");
            }
        }
    }
}
