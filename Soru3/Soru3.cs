using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Soru3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basamak Toplayıcıya Hoşgeldiniz...");
            Console.Write("Basamaklarını toplamak istediğiniz 3 basamaklı sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi / 10) % 10;
            int yüzler = sayi / 100;
            int bastoplam = birler + onlar + yüzler;
            Console.WriteLine("Girdiğiniz üç basamaklı sayının basamak toplamları : " + bastoplam);
            Console.ReadKey();
        }
    }
}
