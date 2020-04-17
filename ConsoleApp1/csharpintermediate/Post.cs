using System;

namespace ConsoleApp1
{
    class Post
    {
        public string Title { get; set; }
        public string Desription { get; set; }

        public DateTime PostedTime { get; }

        public int CurrentVote { get; private set; } = 0;


        public Post(string title, string description)
        {
            this.Title = title;
            this.Desription = description;
            this.PostedTime = DateTime.Now;
        }

        public void UpVote()
        {
            CurrentVote += 1;
        }

        public void DownVote()
        {
            CurrentVote -= 1;
        }

    }

}

