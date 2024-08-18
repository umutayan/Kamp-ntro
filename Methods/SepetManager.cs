using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }


        public void Ekle2(string Adi , string aciklama, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " +  Adi);
        }


    }
}
