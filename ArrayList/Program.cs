using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {   //ArrayList koleksiyon türünde bir sınıftır. İstediğimiz veri türünü tutar ve yardımcı metotlar kullanır.
            //primitive array(ilkel dizi) tanımlayalım

            string[] names = { "Dilara", "Emre", "Oğuz", "Ebrar" };
            foreach (string a in names)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
