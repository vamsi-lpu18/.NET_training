class Program
{
    public static void Main()
    {


        // tast-1
        // string sent = "[INFO] 2025-03-21T14:22:19Z";
        // string pat = @"^\[(INFO|WARN|ERROR|DEBUG|CRITICAL)\] \d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$";

        // Match m = Regex.Match(sent, pat);

        // Console.WriteLine(m.Success); 



        //task-2
            
                    // string sent = "passwordTemp123";
                    // string pat = @"(?i)\bpassword[a-z0-9]+|\bpassword='[a-z0-9]+'";

                    //     Match m = Regex.Match(sent, pat);

                    // Console.WriteLine(m.Value);


                    //task-3
                    // string sent = "password=abc123";
                    // string pat = @"\bpassword(?!=(\*{4}|X{5}|#{4}))[a-zA-Z0-9]+";

                    // Match m = Regex.Match(sent, pat);

                    // Console.WriteLine(m.Value);


                    //task-4
            //         string sent = "passwordTemp123";
            // string pat = @"\bpassword[a-zA-Z0-9]*\b";

            // string result = Regex.Replace(sent,pat,"***REDACTED***");
            // Console.WriteLine(result);


            // task-5;

 string sent = "SELECT * FROM users WHERE password='abc123'";
string pat = @"(?i)(?=.*\bSELECT\b)(?=.*\bWHERE\b)(?=.*\bpassword\b).*";

Match m = Regex.Match(sent, pat);

Console.WriteLine(m.Success);

    }
}