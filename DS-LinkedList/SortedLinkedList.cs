using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    class SortedLinkedList
    {
        Node head;
        public void Add(int data, SortedLinkedList list)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            //sorting
            int size = list.Size();
            if (size > 1)
            {
                int[] arrayOfLinkedListElements = new int[size];
                Node n = head;
                int i = 0;
                while (n.next != null)
                {
                    arrayOfLinkedListElements[i] = n.data;
                    n = n.next;
                    i++;
                }
                arrayOfLinkedListElements[i] = n.data;

                Array.Sort(arrayOfLinkedListElements);

                head = null;
                foreach (int element in arrayOfLinkedListElements)
                {
                    list.Append(element);
                }
            }
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public int Size()
        {
            int size = 0;
            Node n = head;
            if (head != null)
            {
                size = 1;
                while (n.next != null)
                {
                    n = n.next;
                    size++;
                }
            }
            return size;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Console.Write("Current SortedLinkedList : ");
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
