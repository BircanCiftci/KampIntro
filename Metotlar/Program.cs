using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu şekilde yazıldığında 1 ürün için bu bilgilerin tanımlandığı düşünülemez
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe -- ürün güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("---------------Metotlar---------------------");

            // instance - örnek
            // encapsulation - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); // metotu çağırırız
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
//Dont repeat yourself - DRY - Clean Code - Best Practice 