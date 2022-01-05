using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {       //count
            ArrayList collection = new ArrayList();

            collection.Add("Dilara");
            collection.Add("Emre");
            collection.Add("Ebrar");
            collection.Add("Oğuz");
            collection.Add("Yunus");

            int count = collection.Count;
            Console.WriteLine(count);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
