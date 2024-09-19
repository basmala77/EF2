using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eff2
{
    public class Post
    {
        public int id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ?BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
