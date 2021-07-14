using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Soru5
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Sıralamak istedğiniz üç sayıyı giriniz:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("Sıralama şu şekildedir: "+a+">"+b+">"+c);
                    }
                    else
                    {
                        Console.WriteLine("Sıralama şu şekildedir: " + a + ">" + c + ">" + b);

                    }
                }
                else
                {
                    Console.WriteLine("Sıralama şu şekildedir: " + c + ">" + a + ">" + b);

                }
            }
            else if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Sıralama şu şekildedir: " + b + ">" + a + ">" + c);

                }
                else
                {
                    Console.WriteLine("Sıralama şu şekildedir: " + b + ">" + c + ">" + a);

                }
            }
            else
            {
                Console.WriteLine("Sıralama şu şekildedir: " + c + ">" + b + ">" + a);
            }
            Console.ReadKey();
        }
    }
}
