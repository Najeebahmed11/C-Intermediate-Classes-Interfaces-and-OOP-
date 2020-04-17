using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance
            var text = new Text();
            //equal,get hash,get string.These methods are defined in objet class.which is parent of all class in .net
            text.Addhyperlink("najeeb");
        }            
    }

}

