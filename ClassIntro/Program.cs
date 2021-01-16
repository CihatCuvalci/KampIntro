using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Cihat";
            int yas = 36;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni + " "+kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.KursEgitmeni+" "+kurs2.IzlenmeOrani);
            // Console.WriteLine(kurs3.KursAdi + " " + kurs3.KursEgitmeni+" "+kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.KursEgitmeni+"  %"+kurs.IzlenmeOrani);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
