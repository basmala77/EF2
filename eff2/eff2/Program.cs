using Microsoft.EntityFrameworkCore;

namespace eff2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();

            //var blogs = new List<Blog>

            //    {
            //        new Blog { Name = "Ykbdia" },
            //        new Blog { Name = "Elhaya" },
            //        new Blog { Name = "Elnhar"}
            //    };

            //var posts = new List<Post>

            //    {
            //        new Post {  Title = "Post1 - Blog2", Description ="Test Content", BlogId = 2 },
            //        new Post { Title = "Post2 - Blog3" , Description ="Test Content", BlogId = 3 },
            //        new Post { Title = "Post3 - Blog1" , Description ="Test Content", BlogId = 1},
            //        new Post { Title = "Post4 - Blog3" , Description= "Test Content", BlogId = 3},
            //        new Post { Title = "Post5 - Blog2", Description = "Test Content", BlogId = 2},
            //        new Post { Title = "Post6 - Blog1", Description ="Test Content ", BlogId = 1}
            //    };
            ////context.Blogs.AddRange(blogs);
            //context.Posts.AddRange(posts);

           // var b = context.Blogs.Find(3);
      
            //context.Remove(b);
           // context.SaveChanges();
           context.Database.ExecuteSqlRaw("prcAddBlog @Name = 'Test2'");
           

        }
    }
}
