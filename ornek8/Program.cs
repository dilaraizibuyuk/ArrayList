using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek8
{
    class Program
    {
        static void Main(string[] args)
        {       //index of
            ArrayList collection = new ArrayList();

            collection.Add("Dilara");
            collection.Add("Emre");
            collection.Add("Ebrar");
            collection.Add("Oğuz");
            collection.Add("Yunus");

            int index = collection.IndexOf("Emre");
            Console.WriteLine("Index numarası"+index);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
