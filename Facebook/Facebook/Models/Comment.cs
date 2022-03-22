using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Models
{
    class Comment
    {
        public string text;
        public string commenteddate;
        public User user;


        public Comment()
        {

        }
        public Comment(string text,string commenteddate)
        {
            this.text = text;
            this.commenteddate = commenteddate;
        }

        
    }
}
