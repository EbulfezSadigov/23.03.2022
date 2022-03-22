using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Models
{
    class Post
    {
        public string text;
        public string shareddate;
        public int likecount;
        public int commentcount;
        public string [] Comment;

        public Post(string text,int likecount)
        {
            this.text = text;
            this.likecount = likecount;
        }
    }
}
