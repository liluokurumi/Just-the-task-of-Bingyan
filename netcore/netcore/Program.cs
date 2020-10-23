using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//模拟队列,列表,栈,链表
namespace netcore
{
    class Program
    {
        static void Main()
        {
            //队列
            // SeQueue<int> queue1 = new SeQueue<int>(100);
            // queue1.EnQueue(1);
            // for (int item = 3;item <= 102;item++)
            // {
            //     queue1.EnQueue(item);
            // }
            // for (int n = 3;n <= 102;n++)
            // {
            //     Console.WriteLine(queue1.DeQueue());
            // }
            //列表
            // SimulatedList<int> list1 = new SimulatedList<int>();
            // list1.CreatList(10);
            // for(int i = 0;i<=20;i++)
            // {
            //     list1.AddList(i-100);
            //     Console.WriteLine(list1[i]);

            // }
            // Console.WriteLine(list1.GetIndexOf(-95));
            // list1.Insert(14,332501);
            // for (int i = 14;i<=20;i++)
            // {
            //     Console.WriteLine(list1[i]);
            // }
            // list1.Remove(14);
            // for (int i = 14;i<=20;i++)
            // {
            //     Console.WriteLine(list1[i]);
            // }
            //栈
            // SimulatedStack<int> Stack1 = new SimulatedStack<int>();
            // Stack1.SeStack(10);
            // for(int i=0;i<=30;i++)
            // {
            //     Stack1.Push(i-100);
            //     Console.WriteLine(Stack1.Peek());
            // }
            // for(int i = 0;i<=15;i++)
            // {
            //     Console.WriteLine(Stack1.Pop());
            // }
            // 链表
            // LinkedListItem<int> a = new LinkedListItem<int>(4464);
            // LinkedList<int> linkedList1 = new LinkedList<int>(a,2626);
            // LinkedListItem<int> b = new LinkedListItem<int>(8848);
            // linkedList1.Add(b);
            // LinkedListItem<int> c = new LinkedListItem<int>(44648848);
            // linkedList1.Insert(a,c);
            // Console.WriteLine(a.Next.Content);
            // linkedList1.Remove(c);
            // Console.WriteLine(a.Next.Content);
            // LinkedListItem<int> d = new LinkedListItem<int>(8848123);
            // linkedList1.Add(d);
            // Console.WriteLine(b.Next.Content);
            // LinkedListItem<int> e = linkedList1.Find(4464);
            // Console.WriteLine(e.Next.Content);
            // LinkedListItem<int> f = new LinkedListItem<int>(9999);
            // linkedList1.AddToFirst(f);
            // Console.WriteLine(f.Next.Content);

        }
    }
}
