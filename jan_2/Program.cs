using System.Data.Common;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Deconstruct(out int id, out string name)
    {
        id = Id;
        name = Name;
    }
}
class Program
{
    public static (bool valid,string Message) check(string user)
    {
        if (string.IsNullOrEmpty(user))
        {
            return (false,"user is required");
        }
        return (true,"user registered");
    }
    public static void Main()
    {
        // Console.WriteLine("creating objects");
        // List<MyClass>l=new List<MyClass>();
        // for(int i = 0; i < 5; i++)
        // {
        //     // MyClass obj=new MyClass();
        //     l.Add(new MyClass());
        // }
        // // l=null;
        // l.Clear();
        // Console.WriteLine("Forcing garbage collector");
        // GC.Collect();
         
        // GC.WaitForPendingFinalizers();
       
        // Console.WriteLine("Garbage collection Completed");
        // GC.Collect();

        /// tuples
//        var student = (id: 21, name: "abcd");
// Console.WriteLine(student.GetType());
//         (int,string,string ) stu=(12,"abbjcd","sdadad");
//         Console.WriteLine(stu.GetType());


                /// Anonymous type
                var student = new{ 
                    id = 1213,name = "343423"
                };
                // Console.WriteLine(student.GetType());



        /// to return multiple value we use tuples to prevent using out parameter;
        /// 
        // Console.WriteLine(tuple(2,3).prod);
        // Console.Write(check("").valid);




        ///---------------------->packing and unpacking<--------------------------
        // var person=(id:12,name:"sdaadsad");
        // Console.WriteLine(person.id);
        // var(id,name)=person;
        // Console.WriteLine(id.GetType());
        var s = new Student { Id = 1, Name = "Amit" };
            Console.WriteLine(s.GetType());
        var (sid, sname) = s;

        Console.WriteLine(sid);
        Console.WriteLine(sname);

    }
    public static (int Sum, int avg,int prod) tuple(int a,int b)
    {
        return (a+b,(a+b)/2,a*b);
    }
}
class MyClass
{
    ~MyClass()
    {
        Console.WriteLine("Finalizer called object collected");
    }
}