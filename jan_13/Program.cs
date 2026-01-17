using System.Reflection;

// class Employee
// {
//     static int a;
//       public  int solve()
//     {
//         // a+=34;
//         return a;
//     }
// }
// class Program
// {
  
//     public static void Main()
//     {
//         Assembly assembly = Assembly.GetExecutingAssembly();
// // // Other commonly used methods include:
// //     Assembly.Load("MyLibrary");
// //     Assembly.LoadFrom("MyPlugin.dll");
//     Employee emp=new Employee();
// Type type=typeof(Employee);
// // Console.WriteLine(assembly);
//     // 
//     MethodInfo method=type.GetMethod("solve");
//     method.Invoke(new Employee(), null);
//     Console.WriteLine(method);
//     Assembly assembly = Assembly.GetExecutingAssembly();

// foreach (Type type in assembly.GetTypes())
// {
//     if (type.Name.EndsWith("Service"))
//     {
//         Console.WriteLine("Discovered Service: " + type.Name);
//     }
// }


//     }
// }

using System;
using System.Reflection;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine("Employee working");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Employee);

        Console.WriteLine("Class Name: " + type.Name);
        Console.WriteLine("Namespace: " + type.Namespace);

        Console.WriteLine("\nProperties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine($"{prop.Name} - {prop.PropertyType}");
        }

        Console.WriteLine("\nMethods:");
        // foreach (MethodInfo method in type.GetMethods())
        // {
        //     Console.WriteLine(method.Name);
        // }
        // Type type = typeof(Employee);
object obj = Activator.CreateInstance(type);
Console.WriteLine(obj);

MethodInfo method = type.GetMethod("Work");
method.Invoke(obj, null);

    }
}


