
using System.Collections.Concurrent;
using ItemsAlias=LibrarySystem.Items;
class Program
{
    static void Main()
    {
        //task1
        // LibraryItem b1 = new Book("Villains", "Vamsi", 123);
        // b1.Details();
        // Console.WriteLine("Late Fee: " + b1.Calculate(5));

        // Console.WriteLine();
//!SECTION  task2
        // LibraryItem m1 = new Magazine("Tech Weekly", "Editor", 456);
        // m1.Details();
        // Console.WriteLine("Late Fee: " + m1.Calculate(5));
        // List<LibraryItems> list=new List<LibraryItems>();
        // list.Add(new Books("Villains"));
        // list.Add(new Books("side"));
        // list.Add(new Magazines("heroes"));
        // list.Add(new Magazines("females"));
        // foreach(LibraryItems l in list)
        // {
        //    Console.WriteLine($"name of author is {l.title}"); 
        // }
        
        // Book book = new Book("C# Programming");

        // book.ReserveItem();
        // book.SendNotification("Your reserved book is ready for pickup.");
        //      task3
        //  List<LibraryItem> items = new List<LibraryItem>();

        // items.Add(new Book("C# Fundamentals"));
        // items.Add(new Magazine("Tech Monthly"));

        // foreach (LibraryItem item in items)
        // {
        //     item.DisplayItemDetails();
        // }

        //!SECTION task 4

        // IReservable i=new Book("Reserve first");
        //  INotifiable  im=new Book("Notify first");
        //  i.reserve();
        //  im.accept();

        //!SECTION task 5


        // ItemsAlias.Book book=new ItemsAlias.Book("first Book");
        // book.display();


        ///!SECTION task-6
        // PartialImplement.total+=1;
        // PartialImplement.total+=2;
        // PartialImplement.display();

        ///!SECTION task -7
        /// 
        /// 

        /// 
        /// 
        UserRole userrole=UserRole.Admin;
        ItemStatus status=ItemStatus.Borrowed;
        Console.WriteLine($"userrole: {userrole}");
        Console.WriteLine($"Status is : {status}");
    }
}
