namespace csharpintermediate
{

    public class Program
    {
        static void Main(string[] args)
        {
            var dbmig = new DbMigrat(new FileLogger("D:\\internship\\log.txt"));
            dbmig.Migrate();


        }

    }       
}

