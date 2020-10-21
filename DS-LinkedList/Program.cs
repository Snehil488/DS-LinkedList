using System;

namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();
            Console.WriteLine("Popped last element " + linkedList.PopLast().data);
            linkedList.Display();
        }
    }
}
