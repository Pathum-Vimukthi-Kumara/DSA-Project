using System;

namespace DSA_Project___Dev_Mode
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddLast(Student student)
        {
            Node newNode = new Node(student);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public void Remove(Student student)
        {
            if (Head == null) return;

            if (Head.Data.ID == student.ID)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                Count--;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data.ID != student.ID)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                if (current.Next == null)
                {
                    Tail = current;
                }
                Count--;
            }
        }

        public Node Search(string id)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Display()
        {
            Node current = Head;
            if (current == null)
            {
                Console.WriteLine("No students available.");
                return;
            }

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public class Node
        {
            public Student Data { get; set; }
            public Node Next { get; set; }

            public Node(Student data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}
