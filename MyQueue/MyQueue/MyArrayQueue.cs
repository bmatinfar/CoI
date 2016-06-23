using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class MyArrayQueue:IMyQueueInterface
    {
        private const int SIZE = 1000;
        private int front;
        private int back;
        private int current;
        private int total;

        public object[] Que;

        public MyArrayQueue()
        {
            total = SIZE;
            Que = new object[SIZE];
            front = 0;
            back = -1;
        }
        public bool IsEmpty()
        {
            return current == 0;
        }

        public object Dequeue()
        {
            if (IsEmpty())
                throw new OverflowException();

            var p = Que[back%total];
            back ++;
            current++;
            return p;
        }

        public void Enqueue(object obj)
        {
            if(current == total)
                throw new ArgumentOutOfRangeException();

            back++;
            Que[back%total] = obj;
            current++;
        }
    }
}
