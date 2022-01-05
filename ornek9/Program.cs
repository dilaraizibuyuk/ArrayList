using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek9
{
    class Program
    {
        static void Main(string[] args)
        {       //contains
            ArrayList collection = new ArrayList();

            collection.Add("Dilara");
            collection.Add("Emre");
            collection.Add("Ebrar");
            collection.Add("Oğuz");
            collection.Add("Yunus");

            bool control = collection.Contains("Ebrar"); //dizide ebrar var mı?
            Console.WriteLine("Dizide ad var mı?"+control);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
