interface IReservable
{
    void reserve();
}

interface INotifiable
{
    void accept();
}

class Book:IReservable, INotifiable
{
    public string title{get; set;}
    public Book (string title)
    {
        title=title;
    }
    // public void reserve()
    // {
    //     Console.WriteLine($"{title} has been reserved");
    // }
    // public void accept()
    // {
    //     Console.WriteLine("Successfully notified");
    // }
    void IReservable.reserve()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Reserved suvvessfully");
    }
    void INotifiable.accept()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Accpeted successfully");
    }
}