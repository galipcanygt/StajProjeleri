using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    class Soru8
    {
        static void Main(string[] args)
        {
            int karetop = 0, küpçcarp = 1;
            int girilen = Convert.ToInt32(Console.ReadLine());
            for (int sayi = 4; sayi < girilen; sayi+=2)
            {
                karetop += sayi ^ 2;
                küpçcarp *= sayi ^ 3;
            }
            Console.WriteLine("Karelerin toplamı : "+karetop+" küplerin çarpımı : " + küpçcarp);
            Console.ReadKey();
        }
    }
}
