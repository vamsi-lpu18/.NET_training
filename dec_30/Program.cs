using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

class Program
{
    public static void Main()
    {
        string sent;
        // sent="abcd123";
        string pat;
        // pat=@"\d";
        //  sent="123_123"; 
        // bool res=Regex.IsMatch(sent,pat);

        // sent="amount_5000";
        // pat=@"\d+";
        // sent="10a20b30!@_abc  \t";
        // pat=@"\D";
        // pat=@"\W"; //----------------->Non-word Character
        // pat=@"\w"-------------------->
        // Match m=Regex.Match(sent,pat);
//          sent = "10a20b30!@_abc";
//          pat = @"\w";

// MatchCollection matches = Regex.Matches(sent, pat);

// foreach (Match m in matches)
// {
//     Console.Write(m.Value + "");
// }
    // sent = "10#20b30c!@_abc _0!\t c:\\abc\\file.txt";
//  pat = @"\\";
//  sent = "?10#20b30c!@_abc _0!\t c:\\abc\\file.txt?";
//  pat=@"\?";
//  sent = "Hello?10#20b30c!@_abc _0!\t c:\\abc\\file.txt?Hello";
//  pat=@"lo$";
// pat=@"^H";
// pat=@"^Hello$";

// MatchCollection matches = Regex.Matches(sent, pat);
// Match firstMatch = Regex.Match(sent, pat);
// Console.WriteLine($"Firstmatch : {firstMatch}");
// foreach (Match item in matches)
// {
//     Console.Write(item.Value);
// }



        ///--------------------------------------->Named GRoupd <------------------------------------------------------///!SECTION
    //     sent="Amount=5000";
    //     pat=@"Amount=(?<value>\d+)";
    //     MatchCollection matches = Regex.Matches(sent, pat);
    //     Match firstMatch = Regex.Match(sent, pat);
    //     Console.WriteLine(firstMatch.Groups["year"].Value);
    //     Console.WriteLine($"Firstmatch : {firstMatch}");
    //     foreach (Match item in matches)
    // {
    //     Console.Write(item.Value);
    // }  
           sent = "1992-04-23";
        // sent="23-03-1992";
        pat = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";

            // Match m = Regex.Matches(sent, pat);
            // Console.WriteLine($"{m.Groups["year"].Value}-{m.Groups["month"].Value}-{m.Groups["date"].Value}");
            // MatchCollection matches = Regex.Matches(sent, pat);
            // // Match m = Regex.Matches(sent, pat);

            //     foreach (Match m in matches)
            //     {
            //         Console.WriteLine(
            //         // $"{m.Groups[0].Value}-" +
            //         // $"{m.Groups[1].Value}-" +
            //         $"{m.Groups[2].Value}");
            //     }


                //----------------------->Quantifiers<---------------------

        //         sent="a!-@e";
        //         // pat=@"a.."; app
        //         pat=@"a...e";
        //         // pat=@
        //         MatchCollection m=Regex.Matches(sent,pat);
        //         foreach(Match ma in m)
        // {
        //     Console.WriteLine(ma.Value);

        // }




        List<string> Emails = new List<string>
{
    "john.doe@gmail.com",
    "alice_123@yahoo.in",
    "mark.smith@company.com",
    "support-abc@banking.co.in",
    "user.nametag@domain.org",
  "john.doe@gmail",          // Missing domain extension
    "alice@@yahoo.com",        // Double @
    "mark.smith@.com",         // Domain missing name
    "support@banking..com",    // Double dot in domain
    "user name@gmail.com",     // Space not allowed
    "@domain.com",             // Missing username
    "admin@domain",            // No top-level domain
    "info@domain,com",         // Comma instead of dot
    "finance#dept@corp.com",   // Invalid character #
    "plainaddress"   ,
              // Missing @ and domain
              "yahoo.com"

};
            pat=@"\b[\w.-]+@[\w.-]+\.\w{2,}\b";
            List<string> l=new List<string>();
            foreach(string t in Emails)
        {
            if (Regex.IsMatch(t, pat))
            {
                l.Add(t);
            }
        }  
        foreach(string t in l)
        {
            Console.WriteLine(t);
        }

    }
}