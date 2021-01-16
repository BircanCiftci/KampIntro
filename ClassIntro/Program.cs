using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Bircan";
            int yas = 22;

            /* Kurs diye bir değişken tanımlayabilmek için classı olmalı tipi = Kurs 
            içinde birden fazla değişken tanımlıyor */
            // classın değerlerini atamak için kullanılır
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Bircan ÇİFTÇİ";
            kurs1.IzlenmeOrani = 39;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Serhat DEVECİ";
            kurs2.IzlenmeOrani = 40;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Bircan ÇİFTÇİ";
            kurs3.IzlenmeOrani = 39;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Serhat DEVECİ";
            kurs4.IzlenmeOrani = 40;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

            // Kurs classı için array tanımladık 
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
