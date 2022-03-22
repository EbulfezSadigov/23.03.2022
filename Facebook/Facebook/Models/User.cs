using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Models
{
    class User
    {
        public string name;
        public string surname;
        public string email;
        public string DateOfBirth;
        public bool isSingle;
        public string[] Post;

        public User()
        {
            name = "Ebulfez";
            surname = "Sadigov";
        }

        public User(string email, string dateofbirth)
        {
            this.email = email;
            DateOfBirth = dateofbirth;
        }

        public User(bool issingle, string[] post)
        {
            isSingle = issingle;
            Post = post;
        }
    }
}