using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListCycle
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Count the number of nodes");
                Console.WriteLine("3.Search for an element");
                Console.WriteLine("4.Insert an element in empty list/At beginning of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node");
                Console.WriteLine("11.Delete a node");
                Console.WriteLine("12.Reverse the List");
                Console.WriteLine("13.Bubble Sort of the list");
                Console.WriteLine("14.MergeSort");
                Console.WriteLine("15.Insert Cycle");
                Console.WriteLine("16.Find Cycle");
                Console.WriteLine("17.Remove Cycle");



                Console.Write(" enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 15:
                        Console.Write("Enter the element at which the cycle has to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 16:
                        if (list.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not have a cycle");
                        break;
                    case 17:
                        list.RemoveCycle();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}