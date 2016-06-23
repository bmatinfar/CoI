using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {   
        static void Main(string[] args)
        {
            var aStack = new MyArrayStack(20);
            aStack.Pop();

            aStack.Push(100);


        }

    }
}
