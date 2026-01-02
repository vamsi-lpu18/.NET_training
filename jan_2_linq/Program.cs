using System;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;

class Bank
{
    private int balance{get;private set;}
    public void deposit(int amount)
    {
        balance+=amount;
        Console.WriteLine($"{amount} added successfully totla:{balance}");
    }
    public void withdraw(int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("insufficient balance");
        }
        else
        {
            Console.WriteLine($"withdrawan successly { balance}");
        }
    }
}

abstract class Animal
{
    public abstract void bark();
}
class Dog : Animal
{
    public override void bark()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Dog is barking");
    }

}
class Student
{
    public string name{get;set;}
    public int age{get;set;}
    public void display()
    {
        Console.WriteLine($"name= {name} and age={age}");
    }
}
class ResourceHandler
{
    public ResourceHandler()
    {
        Console.WriteLine("Resource Acquired");
    }
    public void Dispose()
    {
        Console.WriteLine("Resource Released");
    }
}
class Employee
{
    public string Name
    {
        get;set;
    }
    public int Salary
    {
        get;set;
    }
}
class Program
{
    public static void Main()
    {
        // List<Student> students = new List<Student>
        // {
        //     new Student("abcd", 'A', 56),
        //     new Student("dsed", 'A', 70),
        //     new Student("dededaed", 'A', 76),
        //     new Student("nohnoin", 'C', 45),
        //     new Student("nkh8ox", 'D', 30)
        // };

        // var res = students.OrderByDescending(s => s.marks).Select(s => new
        // {
        //     s.name,
        //     result = s.marks > 60 ? "pass" : "fail"
        // }).ToList();
        // Console.WriteLine(res.GetType());

        // foreach (var r in res)
        // {
        //     Console.WriteLine($"{r.name} - {r.result}");
        // }

        // Console.WriteLine(res.GetType());
        // int []nums={1,6,324,6,3,6,8,34,5,32};
        // var res=nums.OrderBy(n=>n);
        // var res1=nums.OrderByDescending(n=>n);
        // Console.WriteLine(res);
        List<Employee>l=new List<Employee>();
        l.Add(new Employee
        {
            Name="a",Salary=200
        });
        l.Add(new Employee
        {
            Name="b",Salary=300
        });
        l.Add(new Employee
        {
            Name="c",Salary=400
        });
        l.Add(new Employee
        {
            Name="d",Salary=700
        });
        var res=l.OrderByDescending(e=>e.Salary);
        // foreach(Employee e  in res)
        // {
        //     Console.WriteLine($"{e.Name} - {e.Salary}");
        // }
        // using (ResourceHandler handler=new ResourceHandler())
        // {
        //     Console.WriteLine("Using resource...");
        // }
        // Console.WriteLine("End of program");
        //  Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (int i = 0; i < 10000; i++)
        {
            object obj = new object(); // Gen 0 allocation
        }

        // Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        // GC.Collect(); 
        // GC.WaitForPendingFinalizers();

        // Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        // Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
        Student s=new Student
        {
            name="abcd",age=30
        };
        s.display();
    }
}

// class Student
// {
//     public string name;
//     public char grade;
//     public int marks;

//     public Student(string n, char g, int m)
//     {
//         name = n;
//         grade = g;
//         marks = m;
//     }
// }

