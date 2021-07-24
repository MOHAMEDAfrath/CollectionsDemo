using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ListDemo
    {
        public static void ListOperations()
        {
            List<int> list = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter 1 for Adding Elements into the List");
                Console.WriteLine("Enter 2 to print elements in the list");
                Console.WriteLine("Enter 3 to insert element at the index");
                Console.WriteLine("Enter 4 to remove particular element from list");
                Console.WriteLine("Enter 5 to remove element at index");
                Console.WriteLine("Enter 6 to search the list");
                Console.WriteLine("Enter 7 to print the length of the list");
                Console.WriteLine("Enter 8 to sort the list");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        Console.WriteLine("Enter the number of elements to be added");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Enter data:");
                            list.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        break;
                    case "2":
                        Console.WriteLine("The list");
                        foreach (var member in list)
                            Console.Write(member + " ");
                        Console.WriteLine(" ");
                        break;
                    case "3":
                        Console.WriteLine("Enter the element to be inserted in particular index");
                        int data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        list.Insert(index,data);
                        break;
                    case "4":
                        Console.WriteLine("Enter the element to be removed:");
                        list.Remove(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "5":
                        Console.WriteLine("Enter the index of the element to be removed");
                        list.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "6":
                        Console.WriteLine("Enter the elements to searched");
                        Console.WriteLine(list.Contains(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "7":
                        Console.WriteLine("The length {0}",list.Count);
                        break;
                    case "8":
                        Console.WriteLine("Sorted");
                        list.Sort();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
