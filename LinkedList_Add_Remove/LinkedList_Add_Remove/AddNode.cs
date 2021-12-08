using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Add_Remove
{
    public class AddNode<linked>//Created Generic class
    {
        public linked data;
        public AddNode<linked> next;
        public AddNode(linked value)//Constructor
        {
            data = value;
            next = null;
        }
    }
    public class AddLinkedList<linked>
    {
        //Represent the head and tail of the  linked list  
        public AddNode<linked> head;
        public AddNode<linked> tail;

        //Add() will add a new node to the end of the list  
        public void Add(linked data)
        {
            //Create a new node  
            AddNode<linked> newNode = new AddNode<linked>(data);

            //Checks if the list is empty  
            if (head == null)
            {
                //If list is empty, both head and tail will point to new node  
                head = newNode;
                tail = newNode;
            }
            else
            {
                //newNode will be added after tail such that tail's next will point to newNode  
                tail.next = newNode;
                //newNode will become new tail of the list  
                tail = newNode;
            }
        }
        //display() will display all the data i.e presetn in list
        public void display()
        {
            //Node current will point to head  
            AddNode<linked> tempnode = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List Contains: ");
            Console.ResetColor();
            while (tempnode != null)
            {
                Console.Write(tempnode.data + " ");
                tempnode = tempnode.next;
            }
            
        }
    }
}
