using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    interface IStack<T>
    {
        int Count {get; }
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();

    }

}