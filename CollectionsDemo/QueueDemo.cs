using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class QueueDemo
    {
        public static void QueueOperations()
        {
            Queue<int> queue = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Enter 1 for Enqueue");
                Console.WriteLine("Enter 2 for peek");
                Console.WriteLine("Enter 3 for Display");
                Console.WriteLine("Enter 4 for Dequeue");
                Console.WriteLine("Enter 5 to search the stack");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Console.WriteLine("Enter the number of elements to be added");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Enter the data to be pushed");
                            queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        }
                        break;
                    case "2":
                        if (queue.Count > 0)
                        {
                            Console.WriteLine("Peeked {0}", queue.Peek());
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("Empty queue");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Display");
                        if (queue.Count > 0)
                        {
                            foreach (var mem in queue)
                                Console.Write(mem + " ");
                        }
                        else
                        {
                            Console.WriteLine("Empty queue");
                        }
                        Console.WriteLine(" ");
                        break;
                    case "4":
                        Console.WriteLine("Dequeue");
                        while(queue.Count>0)
                            Console.Write(queue.Dequeue()+" ");
                        break;
                    case "5":
                        Console.WriteLine("Enter the element to be searched");
                        Console.WriteLine(queue.Contains(Convert.ToInt32(Console.ReadLine())));
                        break;
                    default:
                        return;
                }
            }
        }

    }
}
