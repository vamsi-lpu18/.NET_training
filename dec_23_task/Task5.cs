using ItemsAlias=LibrarySystem.Items;
namespace LibrarySystem
{
    namespace Items
    {
        class Book
        {
            public string title;
            public Book(string title)
            {
                title=title;
            }
            public void display()
            {
                Console.WriteLine($"Name of the book is {title}");
            }
        }
        class Magazine
        {
            public string title;
            public Magazine(string title)
            {
                title=title;
            }
            public void display()
            {
                Console.WriteLine($"The name of magazine is {title}");
            }
        }
    }
    namespace Users
    {
    //     namespace Users
    // {
        class Member
        {
            public void Display()
            {
                Console.WriteLine("Library member created");
            }
        }
    // }
    }
}