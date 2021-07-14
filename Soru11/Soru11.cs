using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru11
{
    class Soru11
    {
        static void Main(string[] args)
        {
            double maaş = 3000, aYardımı = 0, Prim = 0, yenimaaş;
            int çSayı = 0, üParça = 0;
            Console.Write("Çocuk Sayınızı Giriniz : ");
            çSayı = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üretilen Parça Sayısını Giriniz : ");
            üParça = Convert.ToInt32(Console.ReadLine());
            if (çSayı > 0 )
            {
                if (çSayı == 1)
                {
                    aYardımı = maaş / 20;
                }
                else if (çSayı ==2)
                {
                    aYardımı = maaş / 10;
                }
                else
                {
                    aYardımı=maaş * 0.15;
                }
            }
            if (üParça > 50)
            {
                if (üParça > 100)
                {
                    if (üParça > 150)
                    {
                        if (üParça > 200)
                        {
                            Prim = 0;
                        }
                        else
                        {
                            Prim = maaş / 5;
                        }
                    }
                    else
                    {
                        Prim = maaş * 0.15;
                    }
                }
                else
                {
                    Prim = maaş / 10;
                }
            }
            yenimaaş = maaş+aYardımı+Prim;
            Console.WriteLine("Aile yardımı ve primler ile alacağınız maaş : " +yenimaaş);
            Console.ReadKey();
        }
    }
}
