using System;
using System.Collections.Generic;

namespace Stack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public class Stack
    {

        private readonly List<Object> _objectStack = new List<Object>();

        public void Push(object obj)
        {
            //store any object in stack
            //if null passed, throw InvalidOperationException

            if (null == obj)
                throw new InvalidOperationException("Push got a null argument");

            _objectStack.Add(obj);
        }

        public object Pop()
        {
            
            object ret = null;
            if (_objectStack.Count > 0)
            {
                ret = _objectStack[IndexOfLastObject];
                _objectStack.RemoveAt(IndexOfLastObject);
            }
            else
            {
                throw new InvalidOperationException("Nothing in the stack to Pop");
            }

            return ret;
        }

        public void Clear()
        {
            _objectStack.Clear();
        }


        private int IndexOfLastObject => _objectStack.Count - 1;
    }
}