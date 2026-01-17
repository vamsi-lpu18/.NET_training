using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;
using MiniSocialMedia;

namespace MiniSocialMedia
{
    public interface IPostable
{
    void AddPost(string content);
};
    

    class SocialException:Exception
    {
        public SocialException(string message) : base(message)
        {
            
        }
        public SocialException(string message,Exception inner) : base(message, inner)
        {

        }
    }
    class InvalidEmailFormatException : SocialException
{
    public InvalidEmailFormatException(string msg) : base(msg) { }
}

class LengthExceededException : SocialException
{
    public LengthExceededException(string msg) : base(msg) { }
}
   class Post
    {
        public User Author{get;init;}
        public string Content{get;init;}
        public DateTime CreatedAt;
        public Post(User author,string content)
        {
           if (author == null)
        {
            throw new ArgumentNullException(nameof(author), "Author cannot be null");
        }
        Author=author;
        Content=content;

        }
        public override string ToString()
        {
            // return base.ToString();
            // return Author+"-"+DateTime.Now+"\n"+Content;\
            StringBuilder sb=new StringBuilder();
            sb.Append(Author);
            sb.AppendLine("|");
            sb.Append(Content);
            MatchCollection hashtags=Regex.Matches(Content,@"#[A-Za-z]");
            if (hashtags.Count > 0)
            {
                sb.Append("tags");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }
            return sb.ToString();
        }
       


    }
    
//     class User:IPostable, IComparable<User>
//     {
//         public event Action<Post>? OnNewPost;
//         public string UserName;
//         public string Email;
//         private List<Post> _posts=new List<Post>();
//         private readonly HashSet<string> _following = new(StringComparer.OrdinalIgnoreCase);
//         // public Action OnNewPost;
//         Predicate<string> IsFollowing = username => _following.Contains(username);
//       public User(string userName, string email)
//     {
//         if (string.IsNullOrWhiteSpace(userName))
//         {
//             throw new ArgumentException("Username cannot be empty.");
//         }

//         if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
//         {
//             throw new InvalidEmailFormatException($"Invalid email format: {email}");
//         }

//         UserName = userName.Trim();
//         Email = email.Trim().ToLower();
//         _following.Add(UserName);
//     }
//     public void AddPost(string content)
//         {
//             if (string.IsNullOrWhiteSpace(content))
//             {
//                 throw new ArgumentException($"{content} post content cannot be empty");
//             }else if (content.Length > 280)
//             {
//                 throw new LengthExceededException($"Length exceeded");
//             }
//             // Post post=new Post(UserName,content);
//             Post newPost=new Post(this,content);
//             _posts.Add(newPost);

//             OnNewPost?.Invoke(newPost);
            
//         }
//         public void Notify(Post pos)
//         {
//             Console.WriteLine($"{pos.Author} posted {pos.Content} ");
//             Console.WriteLine($"Post created successfully");
//         }
//         public int CompareTo(User? other)
// {
//     if (other == null) return 1;
//     return string.Compare(UserName, other.UserName, StringComparison.OrdinalIgnoreCase);
// }
//     }
   
// }
class User : IPostable, IComparable<User>
{
    public event Action<Post>? OnNewPost;

    public string UserName { get; }
    public string Email { get; }

    private readonly List<Post> _posts = new List<Post>();
    private readonly HashSet<string> _following =
        new(StringComparer.OrdinalIgnoreCase);

    public Predicate<string> IsFollowing =>
        username => _following.Contains(username);

    public User(string userName, string email)
    {
        if (string.IsNullOrWhiteSpace(userName))
            throw new ArgumentException("Username cannot be empty.");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new InvalidEmailFormatException("Invalid email format");

        UserName = userName.Trim();
        Email = email.Trim().ToLower();
    }

    public void AddPost(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Post content cannot be empty");

        if (content.Length > 280)
            throw new LengthExceededException("Post too long (max 280 characters)");

        content = content.Trim();

        Post newPost = new Post(this, content);
        _posts.Add(newPost);

        OnNewPost?.Invoke(newPost);
    }

    public void Notify(Post pos)
    {
        Console.WriteLine($"{pos.Author.UserName} posted: {pos.Content}");
        // Console.WriteLine("Post created successfully");
    }
    public void Create(Post pos)
        {
            Console.WriteLine($"{pos.Author.UserName} gadi madda gudu");
        }

    public int CompareTo(User? other)
    {
        if (other == null) return 1;
        return string.Compare(UserName, other.UserName,
                               StringComparison.OrdinalIgnoreCase);
    }
     public IReadOnlyList<Post> GetPosts()
        {
            return _posts;
        }
    public int CompareTo(User? user)
    {
        if (user == null) return 1;

        return string.Compare(UserName, user.UserName, StringComparison.OrdinalIgnoreCase);
    }
        public override string ToString()
        {
            return "@"+UserName;
        }
}
partial class User
    {
        public string GetDisplayName()
        {
            return $"User :{UserName} Email : {Email}";
        }
    }
    class Repository<T> where T:class
    {
        private List<T> _items;
        public void Add=(T)=>_items.Add(T);
        public IReadOnlyList GetAll=()=>_items;
        public T Find=(Predicate<T> match)=>_items.FirstOrDefault((e)=>e.Equals(match));

    }
    public static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime pastTime)
    {
        // Calculate difference using UTC
        TimeSpan diff = DateTime.UtcNow - pastTime;

        if (diff.TotalMinutes < 1)
        {
            return "just now";
        }
        else if (diff.TotalMinutes < 60)
        {
            int minutes = (int)diff.TotalMinutes;
            return $"{minutes} min ago";
        }
        else if (diff.TotalHours < 24)
        {
            int hours = (int)diff.TotalHours;
            return $"{hours} h ago";
        }
        else
        {
            // Month and day format (e.g., Mar 12)
            return pastTime.ToString("MMM dd");
        }
    }
        
    }
class Program
{
    public static void Main()
    {
      User user=new User("vamsiprasad","vamsi14roll@gmail.in");
      user.OnNewPost+=user.Notify;
      user.OnNewPost+=user.Create;
    //   user.OnNewPost+=
        user.AddPost("fuck off mother fucker lanja");

    }
}
}