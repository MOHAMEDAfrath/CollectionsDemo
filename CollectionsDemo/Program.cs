using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Demo");
            Console.WriteLine("Enter 1 for List");
            Console.WriteLine("Enter 2 for stack");
            Console.WriteLine("Enter 3 for queueu");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListDemo.ListOperations();
                    break;
                case 2:
                    StackOperations.StackDemo();
                    break;
                case 3:
                    QueueDemo.QueueOperations();
                    break;

            }
        }
    }
}
