using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Soru4
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("En büyüğünü buldurmak istediğiniz 3 sayıyı giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("En büyük sayı : " + a);
                }
                else
                {
                    Console.WriteLine("En büyük sayı : " + c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine("En büyük sayı : " + b);
            }
            else
            {
                Console.WriteLine("En büyük sayı : " + c);
            }
            Console.ReadKey();

        }
    }
}
