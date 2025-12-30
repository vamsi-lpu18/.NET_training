class Program
{
    public static string solve(string s)
    {
        string t=s.ToLower();
        string temp="";
        foreach(char c in t)
        {
            if (!char.IsAsciiLetter(c))
            {
                return "Invalid String";
            }
            else if(Convert.ToInt32(c)%2!=0)
            {
                temp+=c;
            }
        }
        char [] chararray=temp.ToCharArray();
        Array.Reverse(chararray);
        temp=new string(chararray);

        // Array.Reverse(temp);
        string res="";
        for(int i = 0; i < temp.Length; i++)
        {
            if (i % 2 == 0)
            {
                res+=char.ToUpper(temp[i]);
            }else res+=temp[i];
        }
        return res;

    }
    public static void Main()
    {
        string s=Console.ReadLine();
        if (s.Length < 6)
        {
            Console.WriteLine("Minimum 6 length is required");
        }
        else
        {

            string ans=solve(s);
            Console.WriteLine(ans);
        }
    }
}