using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    public class SimulatedList<T>:IIist<T>
    {
        private T[] data;
        private int count = 0;
        private int front;
        private int rear;
        public void CreatList()
        {
            data = new T[0];
        }
        public void CreatList(int size)
        {
            if (size>=0)
            {
                data = new T[size];

            }

        }
        public T GetItem(int index)
        {
            if(index>=0&&index<=count-1)
            {
                return data[index];
            }
            else
            {
                throw new Exception("索引超出范围");
            }
        }
        public T this[int index]
        {
            get
            {
                return GetItem(index);
            }
            set
            {
                if(index>=0&&index<=count-1)
                {
                    data[index] = value;
                }
                else
                {
                    throw new Exception("索引超出范围");
                }
            }

        }
        public void Insert(int index,T item)
        {
            if(index>=0&&index<=count-1)
            {
                if(count==data.Length)
                {
                    var NewArray = new T[data.Length*2];
                    Array.Copy(data,NewArray,Count);
                    data = NewArray;
                }
            }
            for (int i = count -1;i>=index;i--)
            {
                data[i+1]=data[i];
            }
            data[index] = item;
            count++;
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
        public void AddList(T item)
        {
            if(count == data.Length)
            {
                var NewArray = new T[data.Length*2];
                Array.Copy(data,NewArray,count);
                data = NewArray;

            }
            data[count] = item;
            count++;
        }
        public void Remove(int index)
        {
            if(index>=0&&index<=count-1)
            {
                for(int num = index + 1;num<count;num++)
                {
                    data[num-1] = data[num];
                }
                count--;
            }
            else
            {
                Console.WriteLine("索引值超出列表范围");
            }
        }
        public int GetIndexOf(T item)
        {
            for(int i = 0;i<count;i++)
            {
                if(data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }

}