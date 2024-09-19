using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eff1
{
    public class Book
    {
        public int ID { get; set; }
        public string Namee { get; set; }
        public decimal Price { get; set; }

        public int Authorid { get; set; }
        public Author Author { get; set; 
        }  
        public bool IsDeleted { get; set; } 
    }
    public class  Author
    {
        public int Id { get; set;    }
        public string Name { get; set; }

        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public ICollection<Book> Books { get; set; }  // Navigation property

    }
    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection <Author> Authors { get; set;}


    }
}
