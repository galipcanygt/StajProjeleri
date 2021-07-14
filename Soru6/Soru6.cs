using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Soru6
    {
        static void Main(string[] args)
        {
            int çiftler = 0, tekler = 0;
            for (int sayi = 2; sayi < 99 ; sayi++)
            {
                if (sayi % 2 == 0)
                {
                    çiftler += sayi;
                }
                else
                {
                    tekler += sayi;
                }
            }
            Console.WriteLine(çiftler + "   " + tekler);
            Console.ReadKey();
        }
    }
}
