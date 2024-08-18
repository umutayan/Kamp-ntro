using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Umut";
            int yas = 21;
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demirog";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Engin Demirog";
            kurs2.izlenmeOrani = 68;



            kurs[] kurslar = new kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen);
                    
            }
        }
    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
        

    }
}

