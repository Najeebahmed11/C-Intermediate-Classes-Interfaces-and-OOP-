namespace ConsoleApp1
{
    //in C# class can have only one parent
    class Text : Presenationobject
    {
        public int Fontsize { get; set; }
        public int FontName { get; set; }

        public void Addhyperlink(string url)
        {
            System.Console.WriteLine("we added a link to"+url);
        }
    }

}

