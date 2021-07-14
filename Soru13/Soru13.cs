using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru13
{
    class Soru13
    {
        static void Main(string[] args)
        {
            double ort = 0, girilen;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write( i +". sayıyı giriniz:");
                girilen = Convert.ToDouble(Console.ReadLine());
                ort = ort+(girilen / 5);
            }
            Console.WriteLine("Girilen beş sayının ortalaması : " + ort);
            Console.ReadKey();
        }
    }
}
