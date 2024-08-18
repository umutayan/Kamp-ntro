using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Umut", "Mert", "Ali", "Mehmet" };
            //Console.WriteLine(isimler[]);


            List<string> isimler2 = new List<string> { "Umut", "Mert", "Ali", "Mehmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Orhan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
