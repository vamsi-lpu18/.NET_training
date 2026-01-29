using System.Linq.Expressions;
using Microsoft.VisualBasic;

class Student
{
    public int Marks;
    public string Name;
    public int Id;
    public int Age;

    public Student(int marks,string name,int id,int age)
    {
        Marks=marks;
        Name=name;
        Id=id;
        Age=age;
    }
    public static List<Student> sortbydescending(List<Student> stud)
    {
        return stud.OrderByDescending(s=>s.Marks).ThenBy(s=>s.Age).ToList();
        
    }
}
class Program
{
    public static void Main()
    {
        List<Student>l=new List<Student>
        {
        new Student(60,"a",3,20),
        new Student(100,"b",3,21),
        new Student(60,"c",8,19),
        new Student(20,"d",5,22)
        };
        List<Student> res=Student.sortbydescending(l);
        foreach(Student ele in res)
        {
            Console.WriteLine(ele.Name +"-"+ele.Marks+" "+ele.Age);
        }
    }
}