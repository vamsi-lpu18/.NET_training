using System.Text;

class Program
{
    public static void Main()
    {
        // StringBuilder sb=new StringBuilder();
        // sb.Append("hello");
        // sb.Append(" ");
        // Console.WriteLine(sb.Append("World"));
        
        // Console.WriteLine(sb.AppendLine("abcd"));
        // Console.WriteLine(sb.Append("abcd"));
        // Console.WriteLine(sb.Insert(0,"mine"));
        // Console.WriteLine(sb.Remove(0,4));
        // Console.WriteLine(sb.Clear());
        
        // Console.WriteLine(sb);

        // Console.WriteLine($"Before memory : {GC.GetTotalMemory}");
        // for(int i = 0; i < 10000; i++)
        // {
        //     sb.Append(i);
        // }
        // Console.WriteLine($"After allocation : {GC.GetTotalMemory}");



        //--------------------->Equals <----------------------------
        StringBuilder s1 = new StringBuilder("hello");
        StringBuilder s2 = new StringBuilder("hello");

        // Console.WriteLine(s1.Equals(s2)); // False

        StringBuilder s3 = s2;
        // Console.WriteLine(s2.Equals(s3)); // True

        // Console.WriteLine(s1.ToString() == s2.ToString());
        //  // True
        //  Console.WriteLine(s3==s2);
        //  Console.WriteLine((IntPtr(s1)));
        //  Console.WriteLine(ReferenceEquals(s1,s2));
        //  Console.WriteLine(ReferenceEquals(s2,s3));
        //  Console.WriteLine(s1.Equals(s2));
        //  Console.WriteLine(s2.Equals(s3));
        //  Console.WriteLine(s1==s2);
        //  Console.WriteLine(s2==s3);
        string a="abcd";
        string b="abcd";
        string c=b;
        Console.WriteLine(a==b);
        Console.WriteLine(a.Equals(b));
        Console.WriteLine(ReferenceEquals(a,b));
        Console.WriteLine(ReferenceEquals(c,b));

        // Console.WriteLine(GC.GetTotalMemory(false));

    }
}
    // Console.WriteLine(GC.GetGCMemoryInfo(s1));