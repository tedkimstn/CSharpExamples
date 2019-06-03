//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module3
{
    public class Queue2
    {
        //data
        LinkedList<int> myQueueData;
        //methods
        public void Enqueue(int val)
        {
            myQueueData.AddFirst(val);
        }
        public void Dequeue()
        {
            myQueueData.RemoveLast();
        }
        public int Peek()
        {
            return myQueueData.Last();
        }
        public bool IsEmpty()
        {
            return myQueueData.Count == 0;
        }

        //ctor
        public Queue2()
        {
            myQueueData = new LinkedList<int>();
        }
    }


    public class Stack
    {
        //data - we'll base our stack on a linked list
        SinglyLinkedList myStackData;

        //
        public bool IsEmpty()
        {
            return myStackData.IsEmpty() ;
        }

        public void Push(int val)
        {
            myStackData.AddFirst(val);
        }

        public void Pop()
        {
            myStackData.RemoveFirst();
        }


        public int Peek()
        {
            return myStackData.first.value;
        }


        //ctor  
        public Stack()
        {
            myStackData = new SinglyLinkedList();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //create a new node
            Node myNode = new Node(0);

            SinglyLinkedList myList = new SinglyLinkedList();
            //Console.WriteLine(myList.IsEmpty());
            //myList.AddLast(7);

            //myList.PrintList();

            //myList.AddFirst(1);
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            //myList.PrintList();

            //Console.WriteLine();
            //myList.AddLast(10);
            //myList.AddLast(20);
            //myList.AddLast(30);
            //myList.PrintList();

            ////////////////////////////////////
            //myList.Insert(-20);
            //myList.Insert(10);
            //myList.Insert(23);

            //myList.Insert(14);

            //myList.Insert(-21);
            //myList.PrintList();

            //myList.delete(10);
            //myList.PrintList();


            Stack myStack = new Stack();
            int[] myArr = { 1,2,3,4,5,6,7,8};

            Console.WriteLine("display the array:");
            foreach(int val in myArr)
                Console.Write(val+" ");

            foreach (int val in myArr)
                myStack.Push(val);

            for(int i=0;i<myArr.Length;i++)
            {
                myArr[i] = myStack.Peek();
                myStack.Pop();
            }


            Console.WriteLine("display the array:");
            foreach (int val in myArr)
                Console.Write(val + " ");
            //while (!myStack.IsEmpty())
            //{
            //    Console.WriteLine(myStack.Peek());
            //    myStack.Pop();
            //}

            Queue2 myQueue = new Queue2();
            //myQueue.
        }
    }

    class Node
    {
        //data
        public int value { get; set; }
        public Node next;

        //methods

        //ctor
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

    }

    class SinglyLinkedList
    {
        //data
        public Node first;

        //methods
        public bool IsEmpty()
        {
            //if (first == null)
            //    return true;
            //else
            //    return false;
            return first == null;
        }

        public void AddLast(int val)
        {
            if (IsEmpty())
                AddFirst(val);
            else
            {
                Node newNode = new Node(val);

                Node current = first;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
        }
        public void delete(int val)
        {
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");
            else if (val == first.value)
                RemoveFirst();
            else
            {
                Node curr = first;

                while (curr.next != null &&  curr.next.value != val)
                    curr = curr.next;
                if(curr.next == null) //we didn't find the value val in the list
                    throw new Exception("we didn't find  the element in the list");
                else
                    curr.next = curr.next.next;
            }

        }

        public void Insert(int val)//it assumes the list is sorted!!!!
        {
            if (IsEmpty() || val <= first.value)
                AddFirst(val);
            else
            {
                Node newNode = new Node(val); //create a new node
                Node curr = first;
                while (curr.next!=null && curr.next.value < val)
                    curr = curr.next;
                //if (curr.next == null) //ran to the end of the list
                //   curr.next = newNode ;
                //else
                //{
                //    //link in the new node
                //    newNode.next = curr.next;
                //    curr.next = newNode;
                //}
                //link in the new node
                newNode.next = curr.next;
                curr.next = newNode;
            }

        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove first from an emtpy list");
            else
                first = first.next;

        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove last from an emtpy list");
            else if(first.next == null)//we have only one element in the list
            {
                first = null; //empty the list
            }
            else
            {
                Node current = first;
                while (current.next.next != null)
                    current = current.next;
                current.next = null;//remove the last node by making the next to last node point to null 
            }
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.next = first;
            first = newNode;
        }

        public void PrintList()
        {
            Console.WriteLine();
            Console.WriteLine();
            if(IsEmpty())
                Console.WriteLine("the list is empty!!!");
            else
            {
                Node current = first;
                while (current != null)
                {
                    Console.Write(current.value + "  ");
                    current = current.next;
                }
            }
        }
        //ctor
        public SinglyLinkedList()
        {
            first = null;
        }
    }
}
