using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    public class SeQueue<T>:IQueue<T>
    {
        private T[] data;
        private int count;
        private int front;
        private int rear;
        
        public SeQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public SeQueue():this(10)
        {

        }
        public int Count
        {
            get{return count;}
        }
        public int GetLength()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }
        public void EnQueue(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("队列已满");
            }
            else
            {
                data[rear+1] = item;
                rear++;
                count++;
            }
        }
        public T DeQueue()
        {
            if(count > 0)
            {
                T temp = data[front + 1];
                front ++;
                count --;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空");
                return default(T);
            }
        }
        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }

    }

}

