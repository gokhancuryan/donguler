using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
                //girilen sayıya kadar olan tek sayıları yazdır.
                Console.Write("Lütfen bir sayı giriniz : ");
                int sayac = int.Parse(Console.ReadLine());
               for (int i = 0; i < sayac; i++)
               {
                    if (i%2 == 1)
                    {
                        Console.WriteLine(i);
                    }
               } 
               // 1 ile 1000 arasındaki tek çift sayı toplamları
               int tektoplam = 0;
               int cifttoplam = 0;
               for (int i = 1; i <= 1000; i++)
               {
                if (i % 2 == 0)
                {
                    cifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }
               }
               Console.WriteLine($"Tek sayı toplamı {tektoplam}");
               Console.WriteLine($"Çift Sayıların Toplamı {cifttoplam}");
                
                // break ve continue
                for(int i = 0; i<10; i++)
                    if(i == 4)
                        break;
                    Console.WriteLine("Döngüden Çıkıldı.");
            
        }
    }
}