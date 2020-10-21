using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    class LinkedList
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    Console.Write(n.data + " ");
                    n = n.next;
                }
                Console.Write(n.data + "\n");
            }
        }
    }
}
