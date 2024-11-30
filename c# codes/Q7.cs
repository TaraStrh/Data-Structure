using System;
using System.Collections.Generic;

namespace Program
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
        public void Print()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] data = line.Split(' ');
            int i1 = int.Parse(data[0]);
            int i2 = int.Parse(data[1]);
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            SinglyLinkedList<int> smaller = new SinglyLinkedList<int>();
            SinglyLinkedList<int> bigger = new SinglyLinkedList<int>();

            string line2 = Console.ReadLine();
            string[] data2 = line2.Split(' ');

            for (int i = 0; i < i1; i++)
            {
                list.AddFirst(int.Parse(data2[i]));
            }

            Node<int> currentNode = list.Head;
            while (currentNode != null)
            {
                if (currentNode.Data < i2)
                {
                    smaller.AddFirst(currentNode.Data);
                }
                else
                {
                    bigger.AddFirst(currentNode.Data);
                }
                currentNode = currentNode.Next;
            }

            smaller.Print();
            bigger.Print();
        }
    }
}