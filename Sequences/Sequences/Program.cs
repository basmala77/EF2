using static Sequences.ApplicationDbContext;

namespace Sequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var context = new ApplicationDbContext();
            var o = new Order
            {
                Amount = 100
            };
            context.Orders.Add(o); 
            context.SaveChanges();
        }
    }
}
