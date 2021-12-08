using System;
using LinkedList_Add_Remove;
public class CreateList
{
    public static void Main()
    {
        AddLinkedList<int> nodeList = new AddLinkedList<int>();

        //Adding element to the list  
        nodeList.Add(10);
        nodeList.Add(20);
        nodeList.Add(30);
        //Display()- display the element in list
        nodeList.display();

        
    }
}