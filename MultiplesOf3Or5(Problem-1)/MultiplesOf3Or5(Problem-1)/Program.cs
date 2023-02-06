using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ÜcBes = new ArrayList();
            int toplam = 0;
            int sayi = 0;

            for (int i = 0; i < 1000; i++)
            {
                //Console.WriteLine(sayi);
                

                if (sayi % 3 == 0 ||sayi % 5 == 0)
                {
                    ÜcBes.Add(sayi);
                }
                sayi++;
            }

            //foreach (int item in ÜcBes)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (int item in ÜcBes)
            {
                toplam = toplam + item;
            }

            Console.WriteLine(toplam);
            
        }
    }
}