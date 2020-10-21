using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    public class SimulatedStack<T>:IStack<T>
    {
        private List<T> data;
        private int count;
        private int Top;
        
        public void SeStack(int size)
        {
            data = new List<T>(0);
            count = 0;
            Top = -1;
        }
        public int Count
        {
            get{return count;}
        }
        public void Clear()
        {
            count = 0;
            Top = -1;
        }
        public void Push(T item)
        {
            data.Add(item);
            count++;
            Top++;
        }
        public T Pop()
        {
            if(count > 0)
            {
                T temp = data[Top];
                data.RemoveAt(Top);
                Top --;
                count --;
                return temp;
            }
            else
            {
                Console.WriteLine("栈为空");
                return default(T);
            }
        }
        public T Peek()
        {
            T temp = data[Top];
            return temp;
        }
        public bool Exists(T Item)
        {
            for(int i = 0;i<=count;i++)
            {
                if(data[i].Equals(Item))
                {
                    return true;
                }
            }
            return false;
        }

    }

}