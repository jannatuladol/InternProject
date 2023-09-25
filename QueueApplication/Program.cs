using System;
using System.Collections;

namespace QueueApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue my_queue = new Queue();

            my_queue.Enqueue("Barbie");
            my_queue.Enqueue("1");
            my_queue.Enqueue("100");
            my_queue.Enqueue("null");
            my_queue.Enqueue("99.99");
            my_queue.Enqueue("barbie69");

            Console.WriteLine("Total element present in my_queue: {0}", my_queue.Count);
            my_queue.Dequeue();
            my_queue.Dequeue();
            Console.WriteLine("Total element present in my_queue: {0}", my_queue.Count);
            Console.WriteLine("Total element present in my_queue: {0}", my_queue.Peek());


            foreach (var element in my_queue)
            {
                Console.WriteLine(element);
            }


           Console.ReadLine();
        }
    }
}
