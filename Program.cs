using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var tQue = new MyArrayQueue();

            tQue.Enqueue(98.004);
            tQue.Dequeue();
        }
    }
}
