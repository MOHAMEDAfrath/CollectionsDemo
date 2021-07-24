using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class SetDemo
    {
        public static void SetOperation()
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Bike");
            set.Add("Car");
            set.Add("Cycle");
            set.Add("Truck");
            set.Add("Auto");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
    }
}
