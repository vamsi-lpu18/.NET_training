// abstract class LibraryItem
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public int ItemID { get; set; }

//     protected LibraryItem(string title, string author, int itemID)
//     {
//         Title = title;
//         Author = author;
//         ItemID = itemID;
//     }

//     public abstract void Details();
//     public abstract double Calculate(int days);
// }

// class Book : LibraryItem
// {
//     public Book(string title, string author, int itemID)
//         : base(title, author, itemID)
//     {
//     }

//     public override void Details()
//     {
//         Console.WriteLine($"Book ID: {ItemID}");
//         Console.WriteLine($"Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//     }

//     public override double Calculate(int days)
//     {
//         return days * 1.0;
//     }
// }

// class Magazine : LibraryItem
// {
//     public Magazine(string title, string author, int itemID)
//         : base(title, author, itemID)
//     {
//     }

//     public override void Details()
//     {
//         Console.WriteLine($"Magazine ID: {ItemID}");
//         Console.WriteLine($"Title: {Title}");
//         Console.WriteLine($"Author: {Author}");
//     }

//     public override double Calculate(int days)
//     {
//         return days * 0.5;
//     }
// }
