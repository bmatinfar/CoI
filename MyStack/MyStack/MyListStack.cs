using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyListStack:IMyStackInterface
    {
        private LinkedListNode<object> top; 
        public MyListStack()
        {
            top = null;
        }

        public void Push(object obj)
        {
            top = new LinkedListNode<object>(obj);
        }

        public object Pop()
        {
            if (IsEmpty())
                throw new OverflowException();
            var p = top.Value;
            top = top.Next;
            return p;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
