using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.Write("List: ");
            foreach(var i in list)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\n\n\nLinkedList: ");
            LinkedList<int> vs = new LinkedList<int>();
            vs.AddFirst(6);
            vs.AddAfter(vs.First, 10);
            vs.AddAfter(vs.First, 9);
            vs.AddAfter(vs.First, 8);
            vs.AddAfter(vs.First, 7);
            foreach(var i in vs)
            {
                Console.Write($"{i} ");
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("This is 1");
            queue.Enqueue("This is 2");
            queue.Enqueue("This is 3");
            queue.Enqueue("This is 4");
            queue.Enqueue("This is 5");
            Console.Write("\n\n\nQueue: ");
            foreach(var i in queue)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\n\n\nStack: ");
            //stack
            Stack<int> stack = new Stack<int>();
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);
            foreach(var i in stack)
            {
                Console.Write($"{i} ");
            }


            //dictionary<TKey, TValue>
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "dogs");
            keyValuePairs.Add(2, "cats");
            keyValuePairs.Add(3, "lizards");
            keyValuePairs.Add(4, "baby shark");
            keyValuePairs.Add(5, "doo doo doo doo doo doo");
            Console.Write("\n\n\nDictionary: ");
            foreach (KeyValuePair<int, string> kvp in keyValuePairs)
            {
                Console.Write($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
            //SortedList<Tkey,TValue>
            SortedList<int,string> sortedList  = new SortedList<int, string>();
            sortedList.Add(2, "7");
            sortedList.Add(1, "6");
            sortedList.Add(3, "8");
            sortedList.Add(4, "9");
            sortedList.Add(5, "10");
            Console.Write("\n\n\nSortedList: ");
            foreach(KeyValuePair<int, string> kvp in sortedList)
            {
                Console.Write($"Key = {kvp.Key}, Value = {kvp.Value} ");
            }


            //HashSet<T>
            HashSet<int> hash = new HashSet<int>();
            for(int i=0;i<11;i++)
            {
                hash.Add(i * 2);
            }
            Console.Write("\n\n\nHash Table: ");
            foreach(var i in hash)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
