namespace csharpintermediate
{
    partial class Program
    {
        public class calculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach(int number in numbers)
                {
                    sum += number;
                }
                return sum;
            }

        }
    }
}
