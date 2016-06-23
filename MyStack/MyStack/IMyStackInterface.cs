using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public interface IMyStackInterface
    {
        void Push(object obj);
        object Pop();
        bool IsEmpty();
    }
}
