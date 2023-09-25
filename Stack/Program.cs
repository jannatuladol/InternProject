using System;
using System.Collections;

namespace StackApplication
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();


            my_stack.Push("Adol");
            my_stack.Push("J");
            my_stack.Push("Jannat");
            my_stack.Push("null");
            my_stack.Push(265e4);
            my_stack.Push(2638.989);

            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
            my_stack.Pop();


            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Peek());

            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);




            //my_stack.Clear();
            //Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);

            foreach (var element in my_stack)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();


        }
    }
}
