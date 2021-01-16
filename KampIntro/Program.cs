using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarınDunkuDegeri = 7.35;
            double dolarınBugunkuDegeri = 7.45;

            if (dolarınDunkuDegeri>dolarınBugunkuDegeri)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarınDunkuDegeri<dolarınBugunkuDegeri)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

           
            Console.WriteLine("Kategori");

        }
    }
}
