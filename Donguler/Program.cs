using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("Tek tek yazmak bitti");

            //Dizi olmadan yazsaydık kod uzar ve böyle olur her ekleme çıakrma başımıza iş çıkartır

            //array - dizi kullanarak yazarsak eklemelerde herşey daha kolay olur 

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java","Python","C#"};

            for (int i = 0; i < kurslar.Length; i++) // i=i+2 ile i+=2 aynı şey //saymaya 0dan başlıyo program yazılım geliştirm.... 0. eleman
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            // Başka bir dizi şekli

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
