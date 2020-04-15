using System;

namespace csharpintermediate
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newloc)
        {
            if (newloc == null)
            {
                throw ArgumentNullException("new para");
            }
            Move(newloc.X, newloc.Y);
            
        }

        private Exception ArgumentNullException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
