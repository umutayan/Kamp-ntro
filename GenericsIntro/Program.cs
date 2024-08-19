using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Umut");

            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);


            }

        }
    }
}
