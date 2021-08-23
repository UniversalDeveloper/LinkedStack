using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedSteck
{
    class Node
    {
      public  string item;
      public  Node next;

        public Node( string item, Node next)
        {
            this.item = item;
            this.next = next;
        }
        public override string ToString()
        {
            // return item + " " +next?.ToString();
            return item + " " + next?.ToString();
        }
    }
}
