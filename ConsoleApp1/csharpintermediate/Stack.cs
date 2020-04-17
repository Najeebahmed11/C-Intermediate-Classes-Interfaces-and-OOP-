using System;
using System.Collections.Generic;
using System.Text;

namespace csharpintermediate
{
    public class Stack
    {
        private readonly Stack<object> _stack = new Stack<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            _stack.Push(obj);

        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException();

            return _stack.Pop();
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
