using System;
using System.Linq;

namespace csharpadvanvce
{
    //public class RichString : string
    //{

    //}
    public static class StringExtension
    {
        public static string shorten(this string str,int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("number of words shous be zero or more");
            if (numberOfWords == 0)
            
                return "";
            
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;
            return string.Join(" ", words.Take(numberOfWords))+".....";

        }
    }
}
