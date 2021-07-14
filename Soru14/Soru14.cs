using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru14
{
    class Soru14
    {
        static void Main(string[] args)
        {
            int[,] A = new int[6, 6] { { 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 1, 0, 1 }, { 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };
            int[,] B = new int[6, 6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };
            int hak = 1;
            for (int i = 0; i <= 5; i++)
            {
                for (int k = 0; k <= 5; k++)
                {
                    if (A[i, k] != 0)
                    {
                        for (; hak <= 12; hak++)
                        {
                            Console.Write("dikey düzlemdeki tahmininiz: ");
                            int girx = Convert.ToInt32(Console.ReadLine());
                            Console.Write("yatay düzlemdeki tahmininiz: ");
                            int giry = Convert.ToInt32(Console.ReadLine());
                            if ((girx >6 || girx < 1) || (giry > 6 || giry < 1))
                            {
                                Console.WriteLine("Hatalı koordinat girdiniz");
                                break;
                            }
                            //hak1++;

                            if (B[girx-1, giry-1]==0)
                            {
                                B[girx-1, giry-1] = 1;
                                if (A[girx-1, giry-1]==0)
                                {
                                    Console.WriteLine("Iskaladınız");
                                }
                                else
                                {
                                    A[girx-1, giry-1]= 0;
                                    Console.WriteLine("Vurdunuz");
                                    k = 0;
                                    i = 0;
                                    hak++;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bu tahmini daha önceden yapmıştınız.");
                            }
                        }
                    }
                }
            }
            if (hak>12)
            {
                Console.WriteLine("Deneme Hakkınız Kalmamıştır.");
            }
            else
            {
                Console.WriteLine("Tebrikler.. Tüm Gemileri Batırdınız.");
            }
            Console.ReadKey();
        }
    }
}
