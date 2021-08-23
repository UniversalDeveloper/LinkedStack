using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedSteck
{
    class Stack
    {
       Node head;
        public Stack()
        {
            head = null;
        }
        public void push(string item)
        {
            head = new Node(item, head);
           
        }
        public string pop()
        {
            if (head == null) return null;
            string item = head.item.ToString();// получить последний добавленный элемент в  список
            head = head.next;// после возвра последнего элемента переопределить ссылку на следующий элемент
            return item;
        }

        // реализовать вывод элементов из стека не заходя в стек
        public IEnumerable<string> list()
        {
            Node node = head;
            while(node!= null)
            {
                yield return node.item;
                node = node.next;
            }
        }

    }
}
