using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ornek12
{
    class Program
    {
        static void Main(string[] args)
        {   //10 adet sayıyı tek ve çift olarak gösteren arraylist uygulaması yapılacak
            //dizi oluşturucaz ve dizilerin tek ve çift sayılarını vericez ve tek sayıların adedi
            //çift sayıların adedi,sayıların ortalamasını ekrana yazdıracağız. sayılar random olacak.

            ArrayList teksayilar = new ArrayList();
            ArrayList ciftsayilar = new ArrayList();
            int ortalama = 0, toplam = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(1, 100);
                Console.Write(sayi + "   ");
                toplam += sayi;
                if (sayi % 2 == 0)
                {
                    ciftsayilar.Add(sayi);
                }
                else
                {
                    teksayilar.Add(sayi);
                }

            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________");
            ortalama = toplam / 10;

            Console.WriteLine("Sayıların Ortalaması : {0}", ortalama);
            Console.WriteLine("Tek Sayıların Adeti : {0}", teksayilar.Count);
            Console.WriteLine("Çift Sayıların Adeti : {0}", ciftsayilar.Count);
            Console.ReadKey();


        }
    }
}
