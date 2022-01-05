using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek10
{
    class Program
    {
        static void Main(string[] args)
        {       //sort(diziyi küçükten büyüğe sıralıyor)
            ArrayList numbers = new ArrayList();
            numbers.Add(13);
            numbers.Add(87);
            numbers.Add(3);
            numbers.Add(19);
            numbers.Sort();
            foreach (int a in numbers)
            {
                Console.WriteLine(a);
            }
                Console.ReadKey();
        }
    }
}
