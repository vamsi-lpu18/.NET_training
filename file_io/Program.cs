using System.Text.Json;

namespace FileIO.TextHandling
{
    class UserTextManager
    {
        private string filePath="abcd.txt";
        public void WriteUserToFile(string name, int age)
        {
            using (StreamWriter sw=new StreamWriter(filePath))
            {
                sw.WriteLine("Name : "+name);
                sw.WriteLine("Age : "+age);
            }
        }
        public string ReadUserFromFile()
        {
            string content="";
            using (StreamReader sr=new StreamReader(filePath))
            {
                content=sr.ReadLine();
                
            }
            Console.WriteLine(content);
        }

    }
}
namespace FileIO.BinaryHandling
{
    class UserBinaryManager
    {
        private string filePath;
        public void SaveUserBinary(int id, string name)
        {
            using (BinaryWriter bw=new BinaryWriter(File.Open(filePath,FileMode.Create)))
            {
                bw.Write(id);
                bw.Write(name);
            }
        }
        public string LoadUserBinary()
        {
            string content="";
            using (BinaryReader br=new BinaryReader(File.Open(filePath,FileMode.Open)))
            {
                // Console.ReadLine(Convert.ToInt32(br.Read));
                int id=br.ReadInt32;
                string name=br.ReadString;
                Console.WriteLine(id+" "+name);
            }
        }
    }
}
namespace FileIO.SystemManagement
{
    class FileSystemManager
    {
        private string baseDirectory;
        public void CreateDirectory(string folderName)
        {
            // Directory.CreateDirectory
            baseDirectory=folderName;
            if (!Directory.Exists(baseDirectory))
            {
                Directory.CreateDirectory(baseDirectory);
            }
        }
        public void CreateFile(string fileName)
        {

         string path=Path.Combine(baseDirectory,fileName)   ;
            if (!File.Exists(path))
            {
                File.Create(fileName);
            }
        }
        public bool CheckFileExists(string fileName)
        {
            string path=Path.Combine(baseDirectory,fileName);
            return File.Exists(path);
        }
    }
}


namespace Serialization.XML
{
    public class User
    {
        public int Id;
        public string Name;
    }

    public class UserXmlSerializer
    {
        private string filePath = "user.xml";

        public void SerializeToXml(User user)
        {
            XmlSerializer xs = new XmlSerializer(typeof(User));

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xs.Serialize(fs, user);
            }
        }

        public User DeserializeFromXml()
        {
            XmlSerializer xs = new XmlSerializer(typeof(User));

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (User)xs.Deserialize(fs);
            }
        }
    }
}
namespace  Serialization.JSON
{
    public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string filePath="user.json";
            public void SerializeToJson(User user)
        {
            string json=JsonSerializer.Serialize(user);
            File.WriteAllText(filePath,json);

        }
        public User DeserializeFromJson()
        {
            string data=File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<User>(data);
        }
}

}
class Program
{
    static void Main()
    {
        Console.WriteLine("===== TASK 1: TEXT FILE HANDLING =====");
        var textMgr = new FileIO.TextHandling.UserTextManager();
        textMgr.WriteUserToFile("Alice", 25);
        Console.WriteLine(textMgr.ReadUserFromFile());

        Console.WriteLine("===== TASK 2: BINARY FILE HANDLING =====");
        var binMgr = new FileIO.BinaryHandling.UserBinaryManager();
        binMgr.SaveUserBinary(101, "Bob");
        Console.WriteLine(binMgr.LoadUserBinary());

        Console.WriteLine("===== TASK 3: FILE & DIRECTORY MANAGEMENT =====");
        var fsMgr = new FileIO.SystemManagement.FileSystemManager();
        fsMgr.CreateDirectory("Users");
        fsMgr.CreateFile("data.txt");
        Console.WriteLine("File exists: " + fsMgr.CheckFileExists("data.txt"));

        Console.WriteLine("===== TASK 4: XML SERIALIZATION =====");
        var xmlMgr = new Serialization.XML.UserXmlSerializer();
        xmlMgr.SerializeToXml(new Serialization.XML.User { Id = 1, Name = "Alice" });
        var xmlUser = xmlMgr.DeserializeFromXml();
        Console.WriteLine($"XML User Loaded: Id={xmlUser.Id}, Name={xmlUser.Name}");

        Console.WriteLine("===== TASK 5: JSON SERIALIZATION =====");
        var jsonMgr = new Serialization.JSON.UserJsonSerializer();
        jsonMgr.SerializeToJson(new Serialization.JSON.User { Id = 2, Name = "Bob" });
        var jsonUser = jsonMgr.DeserializeFromJson();
        Console.WriteLine($"JSON User Loaded: Id={jsonUser.Id}, Name={jsonUser.Name}");


    }
}
