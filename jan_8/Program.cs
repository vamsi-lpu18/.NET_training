using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

class User
{
    public int Id;
    public string Name;
}
class Program
{
    public static void Main()
    {
        string path="abcd.txt";
        // File.WriteAllText(path,"this is the replacng code");
        // File.AppendAllText(path,"This is the replacing text ");
        // Console.WriteLine("done");
        string Content=File.ReadAllText(path);
        // Console.WriteLine(Content);
        //  string filePath = "log.txt";

        //     // --- BLOCK 1: WRITING ---
        //     // The 'using' block creates the writer.
        //     // When the block ends (}), the writer is automatically Closed/Disposed.
        //     using (StreamWriter writer = new StreamWriter(filePath))
        //     {
        //         writer.WriteLine("Application Started");
        //         writer.WriteLine("Processing Data");
        //         writer.WriteLine("Application Ended");
        //     } 
        //     // <--- At this exact line, the file is closed and saved.


        //     // --- BLOCK 2: READING ---
        //     // Because the file was closed above, we can open it again immediately here.
        //     using (StreamReader reader = new StreamReader(filePath))
        //     {
        //         string line;
        //         // Read the file line by line until the end
        //         while ((line = reader.ReadLine()) != null)
        //         {
        //             Console.WriteLine("Read from log: " + line);
        //         }
        //     }
        //     // <--- At this line, the reader is automatically closed.

        //     Console.WriteLine("Press any key to exit...");
        //     Console.ReadKey();



            ////////------------------------------->streaReader<------------------------------------------
            User user=new User{Id=1,Name="Alice"};
        // //     using (StreamWriter writer=new StreamWriter("user.txt"))
        // // {
        // //     writer.WriteLine(user.Id);
        // //     writer.WriteLine(user.Name);
        // // }
        // // // while((Line=ReadL))
        // // Console.WriteLine("USer data used");
        // using (StreamReader reader = new StreamReader("user.txt"))
        // {
        //     user.Id = int.Parse(reader.ReadLine()); // 1
        //     user.Name = reader.ReadLine();
        // }
        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        ///------------------------------------>binary Writer<----------------------------------------------
        /// 
        // using (BinaryWriter writer=new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        // {
        //     writer.Write(user.Id);
        //     writer.Write(user.Name);
        // }
        // Console.WriteLine("Binary user data saved");
        ///----------------------------------->Binary Reader<--------------------------------------------
        using (BinaryReader reader=new BinaryReader(File.Open("user.bin", FileMode.Open)))
        {
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
        }
    }
}