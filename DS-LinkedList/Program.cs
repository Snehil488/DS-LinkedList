using System;

namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(56);
            linkedList.Append(70);
            linkedList.InsertAtGivenPosition(2, 30);
            linkedList.Display();
        }
    }
}
