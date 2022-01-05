using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek11
{
    class Program
    {
        static void Main(string[] args)
        {           //tostring
         
            int val = 14;
            string msg = "Bu sınıfta " + val.ToString() + " öğrenci vardır.";
            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
