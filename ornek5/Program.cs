using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {       //clear
            ArrayList collection = new ArrayList();

            collection.Add("Dilara");
            collection.Add("Emre");
            collection.Add("Ebrar");
            collection.Add("Oğuz");
            collection.Add("Yunus");

            collection.Clear(); //diziyi sildi 

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
