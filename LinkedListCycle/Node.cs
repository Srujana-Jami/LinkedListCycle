using System;

namespace LinkedListCycle
{
    class Node
    {
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;

        }
    }
}
