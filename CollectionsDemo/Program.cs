using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Demo");
            Console.WriteLine("Enter 1 for List");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ListDemo.ListOperations();
                    break;

            }
        }
    }
}
