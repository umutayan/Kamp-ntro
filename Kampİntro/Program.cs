using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string katgoriEtiketi = "Kategori";
            int ogreniSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu");     
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMı == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");

            }
            else 
            {
                Console.WriteLine("Giris yap butonu");
                    
            }



        }
    }
}
