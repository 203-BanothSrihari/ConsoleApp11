using System;
using System.Collections;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("hello!");
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);// by using enqueue() method we can add values 
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Dequeue();  //by dequeue() we can delete the data

            Console.WriteLine("count the elements in the queue", myQueue.Count);

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }


        }
    }
}
