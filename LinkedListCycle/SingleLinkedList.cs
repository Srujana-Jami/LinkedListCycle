using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListCycle
{
    class SingleLinkedList
    {
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write(" Enter the number of nodes: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {

                p = p.link;
                n++;

            }
            Console.WriteLine("Number of nodes in the list= " + n);
        }
        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
            {
                p = p.link;

            }
            p.link = temp;
        }
   public bool HasCycle()
        {
            if (FindCycle() == null)
                return false;
            else
                return true;
        }
    
    private Node FindCycle()
        {
            if (start == null || start.link == null)
                return null;
            Node slowR = start, fastR = start;
            while(fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;

            }
            return null;        }
    
    public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null)
                return;
            Console.WriteLine("Node at which the cycle is deteccted is " + c.info);

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }
            Console.WriteLine("Number of nodes not included in the cycle are " + lenRemList);

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine("Length of the list is " + lengthList);

            p = start;
            for (int i = 1; i <= lengthList - 1; i++) ;
            p = p.link;
            p.link = null;
            }
    public void InsertCycle(int x)
        {
            if (start == null)
                return;
            Node p = start, px = null, prev = null;

            while(p != null)
            {
                if (p.info == x)
                    px = p;
                prev = p;
                p = p.link;
            }
            if (px != null)
                prev.link = px;
            else
                Console.WriteLine(x + " not present in the list");
        }
    }
}
