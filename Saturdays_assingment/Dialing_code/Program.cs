using System;
using System.Collections.Generic;

namespace DialingCodesApp
{
    public static class DialingCodes
    {
        // private static Dictionary<int, string> dt = new Dictionary<int, string>();

        public static Dictionary<int, string> GetEmptyDictionary()
        {
            return new Dictionary<int, string>();
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int,string>temp=new Dictionary<int, string>();
            temp.Add(1,"abcd");
            temp.Add(2,"def");
            temp.Add(3,"ghi");
            return temp;
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int code, string countryName)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(code, countryName);
            return dic;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> ed, int code, string countryName)
        {
            if (ed.ContainsKey(code))
                ed[code] = countryName;
            else
                ed.Add(code, countryName);

            return ed;
        }

        public static string GetCountryNameFromDictionary(Dictionary<int, string> ed, int countryCode)
        {
            return ed.ContainsKey(countryCode) ? ed[countryCode] : "";
        }

        public static bool CheckCodeExists(Dictionary<int, string> ed, int countryCode)
        {
            return ed.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode,
            string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary.Remove(countryCode);
            }
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            int maxi = int.MinValue;
            string ans = "";

            foreach (var t in existingDictionary)
            {
                if (t.Value.Length > maxi)
                {
                    maxi = t.Value.Length;
                    ans = t.Value;
                }
            }
            return ans;
        }
    }
}

class Program
{
    public static void Main()
    {
        var dict = DialingCodesApp.DialingCodes.GetEmptyDictionary();
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 91, "India");
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 1, "usa");
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 31, "pakistan");
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 45, "china");
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 9, "russia");
        dict = DialingCodesApp.DialingCodes.AddCountryToExistingDictionary(dict, 87, "japan");
        Console.WriteLine(DialingCodesApp.DialingCodes.FindLongestCountryName(dict));


        // foreach (var item in dict)
        // {
        //     Console.WriteLine($"{item.Key} : {item.Value}");
        // }
    }
}
