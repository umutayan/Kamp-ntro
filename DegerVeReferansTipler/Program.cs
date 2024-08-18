using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,bool,float,double değer
            int say1 = 10;
            int say2 = 20;
            say1 = say2;
            say2 = 30;
            Console.WriteLine(say1);
            //interface, class arrays referans
            int[] sayilar1= new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
        }
    }
}
