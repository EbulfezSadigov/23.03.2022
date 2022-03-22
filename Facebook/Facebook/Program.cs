using System;
using Facebook.Models;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {

            User us = new User();
            Console.WriteLine(us.name);
            Console.WriteLine(us.surname);

            User us1 = new User("7ag0he8@code.edu.az","27.01.2001");
            Console.WriteLine(us1.email);
            Console.WriteLine(us1.DateOfBirth);

            Comment com2 = new Comment();
            com2.text = "hello";
            com2.user = us;
            us.name = "Ersad";
            us.surname = "Teymurov";
            Console.WriteLine(com2.user.name);
            Console.WriteLine(com2.user.surname);

            Post ps = new Post("hello",200);
            Console.WriteLine(ps.text);
            Console.WriteLine(ps.likecount);
        }
    }
}
