using System;
using LinkedList_Add_Remove;
/*Lets create a simple Linked List of 56, 30 and 70*/
public class CreateList
{
    public static void Main()
    {
        AddLinkedList<int> nodeList = new AddLinkedList<int>();

        //Adding element to the list  
        nodeList.Add(56);
        nodeList.Add(30);
        nodeList.Add(70);
        //Display()- display the element in list
        nodeList.display();

        
    }
}