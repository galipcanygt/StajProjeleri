using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Soru1
    {
        static void Main(string[] args)
        {
            int toplam, günlük;
            Console.Write("Çocuğunuzun yaşını giriniz: ");
            int çocukYaş=Convert.ToInt32(Console.ReadLine());
            Console.Write("Kalmak istediğiniz gün sayısını giriniz: ");
            int gün = Convert.ToInt32(Console.ReadLine());
            if (çocukYaş < 6)
            {
                günlük = 240;
            }
            else if (çocukYaş>12)
            {
                günlük = 360;
            }
            else
            {
                günlük = 300;
            }
            toplam = gün * günlük;
            Console.Write("Ödemeniz gereken toplam tutar "+toplam+ " liradır");// + kullanarak yazdırılmak istenilenveriyi de yazdırabiliriz..
            Console.ReadKey();

        }
    }
}
