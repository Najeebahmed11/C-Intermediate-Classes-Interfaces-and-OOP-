using System;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("MyPost", "MyDescription");

            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();


            post1.DownVote();
            post1.DownVote();
            post1.DownVote();
            post1.DownVote();

            //count should be 3
            displayPost(post1);

        }

        static void displayPost(Post post)
        {
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Desription);
            Console.WriteLine(post.PostedTime);
            Console.WriteLine($"Current Vote: {post.CurrentVote}");
        }

    }

}

