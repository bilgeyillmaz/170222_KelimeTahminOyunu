using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170222_KelimeTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string sozcuk = "abcçdefghıijklmnoöprsştuüvyzABCÇDEFGHIİJKLMOÖPRSŞTUÜVYZ";
            string rastgeleKelime = " ";
            string harfTahmin;
            for (int i = 0; i < 5; i++)
            {
                rastgeleKelime=rastgeleKelime+sozcuk[rnd.Next(sozcuk.Length)];
            }
            Console.WriteLine(rastgeleKelime);
            int sayac=rastgeleKelime.Length;    
            while (sayac > 0)
            { basla:
                Console.WriteLine( "Lütfen bir harf giriniz.");
                harfTahmin = Console.ReadLine();
                if(rastgeleKelime.Contains(harfTahmin))
                {
                    Console.WriteLine("Tebrikler {0} harfi listemizde mevcuttur.",harfTahmin);
                    break;

                }
                else
                {Console.WriteLine("Tahmininiz hatalıdır, lütfen tekrar deneyiniz.");
                    goto basla;
                }
                    
            }
            Console.ReadLine();
        }
    }
}
