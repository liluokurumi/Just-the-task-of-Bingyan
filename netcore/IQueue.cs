using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    interface IQueue<T>
    {
        int Count {get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void EnQueue(T item);
        T DeQueue();
        T Peek();

    }

}
