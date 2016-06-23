using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyArrayStack : IMyStackInterface
    {
        private const int SIZE = 1000;

        private int top;
        private readonly object[] Stc;

        public MyArrayStack(int size)
        {
            Stc = size <= 0 ? new object[SIZE] : new object[size];

            top = -1;
        }

        public void Push(object obj)
        {
            if (Stc.Length == top)
                throw new OverflowException();
            top++;
            Stc[top] = obj;
        }

        public object Pop()
        {
            if (IsEmpty())
                throw new AccessViolationException();
            var p = Stc[top];
            top--;
            return p;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
