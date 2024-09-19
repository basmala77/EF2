using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eff2
{
    public class Blog
    {
        public int Id { get; set; } 
        public string? Name { get; set; }   
        
        public List<Post>? Posts { get; set; }
    }
}
