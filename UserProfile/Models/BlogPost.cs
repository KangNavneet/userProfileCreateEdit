using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserProfile.Models
{
    public class BlogPost
    {

        public int Id { get; set; }

        public BlogPost Author { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public string Content { get; set; }

        public ICollection<UserDetails> Blogs { get; set; }

    }
}
