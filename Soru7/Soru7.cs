using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Soru7
    {
        static void Main(string[] args)
        {
            int carpım = 1, toplam = 0;
            int girilen = Convert.ToInt32(Console.ReadLine());
            for (int sayi  = 1; sayi  <= girilen; sayi+=2)
            {
                toplam += sayi;
                carpım *= sayi;
            }
            Console.WriteLine("Carpımlar :" + carpım);
            Console.WriteLine("Toplamlar :" + toplam);
            Console.ReadKey();
        }
    }
}
