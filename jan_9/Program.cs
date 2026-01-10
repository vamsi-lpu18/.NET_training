using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Xml.Serialization;


public class User
{
    public int Id{get;set;}
    public string Name{get;set;}
}
class Program
{
    static void Main()
    {
        //--------------------------------------->File-info<--------------------------------------------
        // FileInfo file=new FileInfo("./sample.txt");
        // if (!file.Exists)
        // {
        //     using(StreamWriter writer= file.CreateText())
        //     {
        //         writer.Write("This is the text i wrote in that file");
        //     }
        // }
        // Console.WriteLine("Name : "+file.Name);
        // Console.WriteLine("Size : "+file.Length);
        // Console.WriteLine("Time : "+file.CreationTime);

        /// ------------------------------------------>Directory(it is a static class<-------------------------------------
        // Directory.CreateDirectory("./logs");
        // if (Directory.Exists("logs"))
        // {
        //     Console.WriteLine("folder created successfully");
        // }
    
        ///------------------------------------------>DirectroryInfo<---------------------------------------
        // DirectoryInfo dir=new DirectoryInfo("dirInfo");
        // if (!dir.Exists)
        // {
        //     dir.Create();   

        // }
        // Console.WriteLine("NAme : "+dir.Name);
        // Console.WriteLine("Created on : "+dir.CreationTime);
        // Console.WriteLine("Full path : "+dir.FullName);
        ///---------------------------------------------->Serialization<------------------------------------
        // User user=new User{Id=1,Name="Abcd"};
        // string json=JsonSerializer.Serialize(user);
        // File.WriteAllText("user.json",json);
        // Console.WriteLine(json);
        ///-------------------------------------------->Deserilization<----------------------------------------------
        // string json=File.ReadAllText("user.json");
        // User user=JsonSerializer.Deserialize<User>(json);
        // Console.WriteLine($"user id:{user.Id} and name is {user.Name}");
        ///-------------------------------------------->Xmlserializer<---------------------------------------
        User user=new User
        {
            Id=1,Name="abcd"
        };
        XmlSerializer serializer=new XmlSerializer(typeof(User));
        using (FileStream fs=new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs,user);
        }
        Console.WriteLine("XML serializer" );
        Console.WriteLine(typeof(User));
    }
}