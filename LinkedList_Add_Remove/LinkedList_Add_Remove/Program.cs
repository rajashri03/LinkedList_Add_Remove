using System;
using LinkedList_Add_Remove;
/*Lets create a simple Linked List of 56, 30 and 70*/
bool Run = true;
while(Run)
{
    Console.Write("Select Number:\n1)Adding Node At End\n2)Add Node at Start\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            AddLinkedList<int> nodeList = new AddLinkedList<int>();
            //Adding element to the list  
            nodeList.Add(56);
            nodeList.Add(30);
            nodeList.Add(70);
            //Display()- display the element in list
            nodeList.display();
            break;
        case 2:
            AddLinkedList<int> Startnode = new AddLinkedList<int>();
            Startnode.Add_Start(70);
            Startnode.display();
            Startnode.Add_Start(30);
            Startnode.display();
            Startnode.Add_Start(56);
            Startnode.display();
            break;
        default:
            Run = !Run;
            break;
    }

}


