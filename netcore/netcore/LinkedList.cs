using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore
{
    public class LinkedListItem<T>
    {
        public T Content {get;set;}
        public LinkedListItem<T> Next {get;set;}
        public LinkedListItem(T content)
        {
            this.Content = content;
            this.Next = default(LinkedListItem<T>);
        }
    }
    public class LinkedList<T>
    {
        private LinkedListItem<T> first;
        public LinkedList(LinkedListItem<T> item,T lastcontent)
        {
            first = new LinkedListItem<T>(default(T));
            first.Content = default(T);
            first.Next = item;
        }
        public void Add(LinkedListItem<T> item)
        {
            LinkedListItem<T> item1 = first;
            while(true)
            {
                item1 = item1.Next;
                if(item1.Next == default(LinkedListItem<T>))
                {
                    item1.Next = item;
                    break;
                }
            }
        }
        public void Insert(LinkedListItem<T> LastItem,LinkedListItem<T> item)
        {
            LinkedListItem<T> exchange = LastItem.Next;
            LastItem.Next = item;
            item.Next = exchange;
        }
        public void Remove(LinkedListItem<T> item)
        {
            LinkedListItem<T> item1;
            item1 = first;
            while(true)
            {
                item1 = item1.Next;
                if(item1.Next == item)
                {
                    item1.Next = item.Next;
                    break;
                }
                if(item1.Next == default(LinkedListItem<T>))
                {
                    Console.WriteLine("未找到该元素");
                    break;
                }
            }
        }
        public LinkedListItem<T> Find(T content)
        {
            LinkedListItem<T> item1;
            item1 = first;
            while(true)
            {
                item1 = item1.Next;
                if(item1.Content.Equals(content))
                {
                    return item1;
                }
                if(item1.Next == default(LinkedListItem<T>))
                {
                    Console.WriteLine("未找到该元素");
                    return default(LinkedListItem<T>);
                }
            }
        }
        public void AddToFirst(LinkedListItem<T> item)
        {
            LinkedListItem<T> exchange = first.Next;
            first.Next = item;
            item.Next = exchange;
        }
    }
}