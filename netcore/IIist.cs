using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    interface IIist<T>
    {
        int Count {get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void CreatList();
        void AddList(T item);
        void Remove(int index);
        void Insert(int index,T item);
        int GetIndexOf(T item);
        T GetItem(int index);

    }

}