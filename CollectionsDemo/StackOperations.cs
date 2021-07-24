using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class StackOperations
    {
        public static void StackDemo()
        {
            Stack<int> stack = new Stack<int>();
            while (true)
            {
                Console.WriteLine("Enter 1 for push");
                Console.WriteLine("Enter 2 for peek");
                Console.WriteLine("Enter 3 for Display");
                Console.WriteLine("Enter 4 for pop");
                Console.WriteLine("Enter 5 to search the stack");
                Console.WriteLine("Enter 6 to clear the stack");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Console.WriteLine("Enter the number of elements to be added");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Enter the data to be pushed");
                            stack.Push(Convert.ToInt32(Console.ReadLine()));
                        }
                            break;
                    case "2":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("Peeked {0}",stack.Peek());
                            Console.WriteLine(" ");
                        }
                        break;
                    case "3":
                        if (stack.Count > 0)
                        {
                            foreach(var mem in stack)
                                Console.Write(mem+" ");
                        }
                        else
                        {
                            Console.WriteLine("Empty stack");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Pop operation");
                        while (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Pop()+" ");
                        }
                        if(stack.Count == 0)
                        {
                            Console.WriteLine("Empty stack enter 1 to add");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Enter the element to be searched");
                        Console.WriteLine(stack.Contains(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "6":
                        stack.Clear();
                        Console.WriteLine("Stack Cleared");
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
