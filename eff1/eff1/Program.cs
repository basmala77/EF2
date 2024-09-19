using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace eff1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new ApplicationDbContext_Old();
            //var b = new Book
            //{
            //    ID = 1,

            //};

            //Console.WriteLine("Hello, World!");


            //var s = c.Stocks.Find(100);
            //Console.WriteLine(s?.last_name);


            //var s1 = c.Stocks.Single(s=> s.Id == 100);
            //Console.WriteLine($" ID: {s1.Id} Name : {s1.last_name}");


            //var s2 = c.Stocks.First(s=> s.Id > 50);
            //Console.WriteLine($" ID: {s2.Id} Name : {s2.last_name}");

            //var s3 = c.Stocks.FirstOrDefault(s => s.Id > 100);
            //Console.WriteLine(s3 == null ? "no item found" : $" ID: {s2.Id} Name : {s2.last_name}");

            //var s4 = c.Stocks.OrderBy(m => m.last_name).Last();
            //Console.WriteLine(s4 == null ? "No items found " : $" ID: {s4.Id} Name : {s4.last_name}");


            //var s5 = c.Stocks.Where(s => s.Id > 50).ToList();
            //foreach (var item in s5)
            //{
            //    Console.WriteLine($" ID: {item.Id} Name : {item.last_name}");
            //}
            //var s6 = c.Stocks.Any(s => s.Id > 100);

            //Console.WriteLine(s6);

            //var s7 = c.Stocks.Where(m => m.Id > 60).ToList().Append(new Stocks { Id = 101, first_name = "Basmala" });

            //foreach (var item in s7)
            //{
            //    Console.WriteLine($" ID: {item.Id} Name : {item.last_name}");


            //}

            ////var s8 = c.Stocks.Aggregate(m=> m.)
            //var s8 = c.Stocks.Count();
            //Console.WriteLine(s8);  

            //var s9 = c.Stocks.Min(s => s.Id);
            //Console.WriteLine(s9);

            //var s10 = c.Stocks.Max(s => s.first_name);
            //Console.WriteLine(s10);

            //var s11 = c.Stocks.OrderBy(s => s.first_name).ThenBy(s=> s.Id ).ToList();
            //foreach (var item in s11)
            //{
            //    Console.WriteLine(item.first_name);
            //}

            //var s12 = c.Stocks.Select(m => new { m.Id, m.first_name }).ToList();

            //var s13 = c.Stocks.Skip(10).Take(10).ToList();

            //foreach (var item in s13)
            //{
            //    Console.WriteLine($"{item.Id}");

            //}

            //var book = c.Books
            //    .Join(
            //        c.Author,
            //        book => book.Authorid,
            //        a => a.Id,
            //        (book,a) => new
            //        {
            //            BookID = book.ID,
            //            BookName = book.Namee,
            //            Authorname = a.Name
            //        }
            //    );
            //var a = c.Author
            //    .Join(
            //    c.Nationality,
            //    author => author.NationalityId,
            //    n=> n.Id,
            //    (author,n) => new
            //    {

            //    }
            //    );

            //foreach (var item in book) { Console.WriteLine($"{item.BookID} - {item.BookName} - {item.Authorname}"); }



            //var b1 = c.Books.AsNoTracking().SingleOrDefault(b=> b.ID == 1);
            //b1.Price = 200; //modify
            //var t = c.ChangeTracker.Entries();

            //foreach (var item in t)
            //{
            //    Console.WriteLine($"{item.Entity.ToString()} - {item.State}");
            //}



            //   var b2 = c.Books.AsNoTracking().SingleOrDefault(b => b.ID == 2);
            //   b2.Price = 110;
            //   c.SaveChanges();


            ////defulte noTracking
            ////c.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //   var b3 = c.Books.SingleOrDefault(b => b.ID == 3);
            //   b3.Price = 110;
            //   c.SaveChanges();


            //nullrefexption
            //var book = c.Books.SingleOrDefault(b=> b.ID == 1);
            //Console.WriteLine(book.Author.Name);

            //var book1 = c.Books.Include(b => b.Author).SingleOrDefault(b => b.ID == 2);
            //Console.WriteLine(book1?.Author.Name);

            //Explicit Loading
            //var a = c.Author.SingleOrDefault(b => b.Id == 2);
            //c.Entry(a).Collection(B => B.Books).Load();

            //foreach (var book in a.Books)
            //{
            //    Console.WriteLine(book.Namee);
            //}

            //var bookk = c.Books.Include(b => b.Author).AsSplitQuery().ToList();

            // var books = c.Books.FromSqlRaw("SELECT * FROM Books").ToList();

            //foreach ( var book in books ) { Console.WriteLine(book.Namee); }

            //var n = new Nationality
            //{

            //    Name = "pritaa"
            //};


            //var Author = new Author
            //{
            //    Name = "Eman",
            //    NationalityId = 6,
            //    Books = new List<Book>
            //   {
            //       new Book { Namee = "happy",Price = 400},
            //       new Book { Namee = "sad" , Price = 300}
            //   }
            //};
            ////c.Author.Add(Author);
            //c.Author.Add(Author);
            //c.SaveChanges();



            //////1///////
            //var n = c.Nationality.Find(6);
            //n.Name = "Arabic";
            //c.SaveChanges();


            //////////////2///////////
            //var n1 = new Nationality { Id = 6, Name = "eng" };
            //c.Update(n1);   
            //c.SaveChanges();


            //////////3/////////
            //var current = c.Nationality.Find(6);
            //var newNationalty = new Nationality { Id = 6, Name = "english" };
            //c.Entry(current).CurrentValues.SetValues(newNationalty);
            //c.SaveChanges();

            //var b = new Book
            //{
            //    ID = 5,
            //    Authorid = 10,
            //    Price = 700,
            //    Namee = "happy or sad"
            //};
            //c.Update(b);


            //c.SaveChanges();

            

            List<Product> products = new List<Product>
            {
                new(Name: "product1", price:50.6),
                new(Name: "product2", price:10.6),
                new(Name: "product3", price:40.6),
                new(Name: "product4", price:80.6),
                new(Name: "product5", price:90.6),
                
            };

            var cheapest = products.MinBy(b => b.price);
            Console.WriteLine($"The minimum price is: {cheapest}");

            c.Books.ExecuteUpdate(x => x.SetProperty(e => e.IsDeleted, true));
        }
    }

public record  Product(string Name,double price);
}
