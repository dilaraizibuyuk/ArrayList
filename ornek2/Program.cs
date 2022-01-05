using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //kütüphane eklememiz gerekti

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {   //arraylist

            ArrayList collection = new ArrayList();

            collection.Add("Dilara");   //sırayla ekleniyor
            collection.Add("Emre");
            collection.Add("Ebrar");
            collection.Add("Oğuz");
            collection.Add("Yunus");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
