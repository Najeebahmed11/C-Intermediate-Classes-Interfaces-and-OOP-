using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());
            dbMigrator.Migrate();
            installer.installer();

            //Composition
            //means to dedign loosly couple apps
            
            
        }            
    }

}

