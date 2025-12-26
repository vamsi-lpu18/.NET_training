using System;
interface IPrintable
{
    void Print();
    static void Scan(){}
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}
/// <summary>
/// explicit interfasce
/// </summary>
interface ILogger
{
    void Log();
}
interface INotifier
{
    void Log();
}
class FileLogger : ILogger, INotifier
{
    void ILogger.Log()
    {
        Console.WriteLine("Logging to file via ILogger");
    }
    void INotifier.Log()
    {
        Console.WriteLine("Logging to notification via INotifier");
    }
}


class ResourceHandler : IDisposable, INotifier
{
    void IDisposable.Dispose()
    {
        Console.WriteLine("Resource disposed");
    }
    void INotifier.Log()
    {
        Console.WriteLine("Notification sent");
    }
}

// Accessing via interface references

class Programs
{
    static void Main()
    {
        // Report r=new Report();
        // r.Print();
        //////  explicit interfaces accessing  //////
//         IDisposable resource = new ResourceHandler();
// resource.Dispose();  // Works

// INotifier notifier = new ResourceHandler();
// notifier.Log();     // Works

// ResourceHandler obj = new ResourceHandler();
// obj.Dispose();      // ERROR: not accessible directly
// obj.Log();          // ERROR: not accessible directly

    }
}