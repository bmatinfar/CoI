using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public interface IMyQueueInterface
    {
        bool IsEmpty();
        object Dequeue();
        void Enqueue(object obj);
    }
}
