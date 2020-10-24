using System;

namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.Add(56, sortedLinkedList);
            sortedLinkedList.Add(30, sortedLinkedList);
            sortedLinkedList.Add(40, sortedLinkedList);
            sortedLinkedList.Add(70, sortedLinkedList);
            sortedLinkedList.Display();
        }
    }
}
