class Program
{
    // public static void task3(int[,] arr)
    // {
    //     int n=arr.GetLength(0);
    //     int[][] na=new int[n][];
    //     int avg=20;
    //     for(int i = 0; i < n; i++)
    //     {
    //         int cnt=0;
    //         for(int j = 0; j < arr.GetLength(1); j++)
    //         {
    //             if(arr[i,j]>avg)cnt++;
    //         }
    //         na[i]=new int[cnt];
    //         for(int j = 0; j < cnt; j++)
    //         {
    //             if (arr[i, j] > avg)
    //             {
    //                 na[i][j]=arr[i,j];
    //             }
    //         }
    //     }
    //     for(int i = 0; i < na.GetLength(0); i++)
    //     {
    //         for(int j = 0; j < na[i].Length; j++)
    //         {
    //             Console.WriteLine(na[i][j]+" ");;
    //         }
    //         Console.WriteLine();
    //     }
    // }
    public static void task3(int[,] arr)
{
    int n = arr.GetLength(0);   // rows
    int m = arr.GetLength(1);   // columns

    int[][] na = new int[n][];
    int avg = 1;

    for (int i = 0; i < n; i++)
    {
        int cnt = 0;

        // count elements > avg
        for (int j = 0; j < m; j++)
        {
            if (arr[i, j] > avg)
                cnt++;
        }

        na[i] = new int[cnt];
        int k = 0;  // jagged array index

        // store elements > avg
        for (int j = 0; j < m; j++)
        {
            if (arr[i, j] > avg)
            {
                na[i][k++] = arr[i, j];
            }
        }
    }

    // print jagged array
    for (int i = 0; i < na.Length; i++)
    {
        for (int j = 0; j < na[i].Length; j++)
        {
            Console.Write(na[i][j] + " ");
        }
        Console.WriteLine();
    }
}

    public static void task2()
    {
        Console.WriteLine("Enter number of branches:");
        int m=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of months:");
        int n=Convert.ToInt32(Console.ReadLine());
        int [,] arr=new int[m,n];
        int []sales=new int[m];
        int maxi=0;
        int idx=0;
        for(int i = 0; i < m; i++)
        {
            int sum=0;
            for(int j = 0; j < n; j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
                if (arr[i, j] > maxi)
                {
                    maxi=arr[i,j];
                    idx=j;
                }
                sum+=arr[i,j];
            }
            // Console.WriteLine();
            sales[i]=sum;
        }
        Console.WriteLine("Displaying branch total sales:");
        for(int i = 0; i < m; i++)
        {
            Console.WriteLine($"{i+1} branch sales -> {sales[i]}");
        }
        Console.WriteLine($"Global highest sale is {maxi} in {idx} month");



        task3(arr);
    }
    public static void task_4()
    {
        Console.WriteLine("Enter number of stocks:");
        int n=Convert.ToInt32(Console.ReadLine());
        List<int>l=new List<int>();
        for(int i = 0; i < n; i++)
        {
            l.Add(Convert.ToInt32(Console.ReadLine()));
        }
        HashSet<int>h=new HashSet<int>(l);
        Console.WriteLine("After removing duplicates : ");
        foreach(int x in h)
        {
            Console.WriteLine(x+" ");
        }
    }
    public static void task_5()
    {
        Console.WriteLine("Enter no of products:");
        int n=Convert.ToInt32(Console.ReadLine());
        Dictionary<int,double>d=new Dictionary<int, double>();
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter product id : ");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount : ");
            double amount=Convert.ToDouble(Console.ReadLine());
            d.Add(id,amount);

        }
        SortedList<int,double>s=new SortedList<int, double>(d);
        foreach(KeyValuePair<int,double> t in s.Reverse())
        {
            Console.WriteLine(t.Key+ " "+ t.Value);
        }
    }
    public static void Main()
    {
        // Console.WriteLine("Enter the number of products:");
        // int n=Convert.ToInt32(Console.ReadLine());
        // double[] arr=new double[n];
        // Console.WriteLine("Enter products");
        // double sum=0;
        // for(int i = 0; i < n; i++)
        // {
        //     arr[i]=Convert.ToInt32(Console.ReadLine());
        //     sum+=arr[i];
        // }

        // double avg=sum/(double)n;
        // for(int i = 0; i < n; i++)
        // {
        //     if(arr[i]<avg)arr[i]=0;
        // }
        // Array.Resize(ref arr,n+5);
        // for(int i = n; i < n + 5; i++)
        // {
        //     arr[i]=avg;
        // }
        // for(int i = 0; i < n + 5; i++)
        // {
        //     Console.WriteLine($"{i}- {arr[i]}");
        // }
        // task2();
        // task_4();
        // task_5();
    }
}