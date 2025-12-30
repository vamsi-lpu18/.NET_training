using System;
using System.Text.RegularExpressions;

namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern =
            @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";

        private readonly string splitLineRegexPattern =
            @"<\*{3}>|<={4}>|<\^\*>";

        private readonly string quotedPasswordRegexPattern =
            "\"[^\"]*password[^\"]*\"";

        private readonly string endOfLineRegexPattern =
            @"end-of-line\d+";

        private readonly string weakPasswordRegexPattern =
            @"\bpassword[a-zA-Z0-9]+\b";

        public bool IsValidLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return Regex.IsMatch(text, validLineRegexPattern);
        }

        public string[] SplitLogLine(string text)
        {
            return Regex.Split(text, splitLineRegexPattern);
        }

        public int CountQuotedPasswords(string lines)
        {
            MatchCollection matches =
                Regex.Matches(lines, quotedPasswordRegexPattern, RegexOptions.IgnoreCase);
            return matches.Count;
        }

        public string RemoveEndOfLineText(string line)
        {
            if (string.IsNullOrEmpty(line))
                return "";

            return Regex.Replace(line, endOfLineRegexPattern, "");
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match m = Regex.Match(lines[i], weakPasswordRegexPattern, RegexOptions.IgnoreCase);

                if (m.Success)
                    result[i] = m.Value + ": " + lines[i];
                else
                    result[i] = "--------: " + lines[i];
            }

            return result;
        }
    }
}

class Program
{
    public static void Main()
    {
        LogProcessing.LogParser user = new LogProcessing.LogParser();
        Console.WriteLine(user.IsValidLine("[INF] Application started"));
    }
}
