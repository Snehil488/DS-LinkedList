using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedList
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
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine($"Appended {data} to LinkedList");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
                Console.WriteLine($"Appended {data} to LinkedList");
            }
        }
        public void InsertAtGivenPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head, prev = head, after;
                for (int pos = 1; pos < position; pos++)
                {
                    n = n.next;
                    if (pos == position - 2)
                    {
                        prev = n;
                    }
                }
                after = n;
                prev.next = node;
                node.next = after;
            }
        }
        public Node Pop()
        {
            Node n = head;
            if(head == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            else
            {
                head = head.next;
            }
            return n;
        }
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node removedNode = n.next;
                n.next = null;
                return removedNode;
            }
        }
        public Node Search(int data)
        {
            Node n = head;
            if (head == null)
            {
                Console.WriteLine("LinkedList Empty.");
            }
            if (head.data == data)
            {
                return head;
            }
            else
            {
                while (n.next != null)
                {
                    n = n.next;
                    if (n.data == data)
                    {
                        return n;
                    }
                }
            }
            return null;
        }
        public void InsertNodeAfterParticularNode(int existingNodeData, int newNodeData)
        {
            Node n = Search(existingNodeData);
            if(n != null)
            {
                Node node = new Node(newNodeData);
                node.next = n.next;
                n.next = node;
                Console.WriteLine($"Inserted {newNodeData} after {existingNodeData} into LinkedList");
            }
            else
            {
                Console.WriteLine("Given Element not found.");
            }
        }
        public int Size()
        {
            int size = 0;
            Node n = head;
            if(head == null)
            {
                Console.WriteLine($"Linked List is Empty, Size is {size}");
            }
            else
            {
                size = 1;
                while(n.next != null)
                {
                    n = n.next;
                    size++;
                }
                Console.WriteLine($"Linked List Size is {size}");
            }
            return size;
        }
        public Node DeleteGivenNode(int data)
        {
            Node n = Search(data);
            if(n == null)
            {
                Console.WriteLine("Given Element not found, deletion not possible.");
            }
            else if (n == head)
            {
                head = head.next;
                Console.WriteLine($"Deleted node {n.data}");                
            }
            else
            {
                Node node = head;
                while(node.next.data != n.data)
                {
                    node = node.next;
                }
                Console.WriteLine($"Deleted node {n.data}");
                node.next = n.next;
            }
            return n;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Console.Write("Current LinkedList : ");
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
