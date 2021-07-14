using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Soru2
    {
        static void Main(string[] args)
        {
            Console.Write("Kan Şekerinizi giriniz: ");
            int kansekerdegeri = Convert.ToInt32(Console.ReadLine());
            if (kansekerdegeri<140 && kansekerdegeri>=110)
            {
                Console.WriteLine("Kan şekeriniz yükseliyor. Yediklerinize dikkat edin lütfen.");
            }
            else if (kansekerdegeri>=140)
            {
                Console.WriteLine("Kan şekeriniz çok yükek. Lütfen ilaçlarınızı alınız.");
            }
            else
            {
                Console.WriteLine("Kan şekeri değeriniz normal.");
            }
            Console.ReadKey();
        }
    }
}
