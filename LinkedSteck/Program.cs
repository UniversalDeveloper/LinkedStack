using System;

namespace LinkedSteck
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push("milk");
            stack.push("bread");
            stack.push("cola");
            stack.push("eggs");



            Node node1 = new Node("milk", null);
            Node node2 = new Node("bread", node1);
            Node node3 = new Node("bater", node2);

            foreach (var item in stack.list())
            {
                Console.WriteLine(item);
            }

          //  Console.WriteLine(stack.pop());
           // Console.WriteLine(stack.pop());
           // Console.WriteLine(stack.pop());
            //Console.WriteLine(stack.pop());
           // Console.ReadKey();
        }
    }
}
