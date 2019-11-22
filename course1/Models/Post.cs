using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace course1.Models
{
    public class Post
    {
        public int postId { get; set; }
        public String postAuthor { get; set; }
        public String postTitle { get; set; }
        public String postBody { get; set; }
    }
}