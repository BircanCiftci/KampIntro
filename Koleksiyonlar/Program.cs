using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Bircan", "Serhat", "Mercan", "Aycan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            /* bu şekilde yukarıdaki diziye yeni bir eleman eklemek için yazmaya çalıştığımızda 
            olmaz çünkü diziye müdehale edemeyiz. Bu şekilde yeni bir dizi oluşturmuş oluruz ve 
            sadece 4. elemanını tanımlamış oluruz. Yukaradaki dizi ile hiçbir bağlantısı olmaz.
            Ondan bağımsız yeni bir dizi oluşur. Buşekilde yapınca var olan indekslerdeki değerleri
            de kaybedebiliriz. İki dizininde referans tipleri farklı olur. Böyle bir sorun olduğu
            için Listler kullanılır yani koleksiyon */
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // Yukarıdaki diziyi koleksiyon ile bu şekilde tanımlarız.
            List<string> isimler2 = new List<string> { "Bircan", "Serhat", "Mercan", "Aycan" };
            //isimler2.Add("Bircan"); // elemanları bu şekilde de tanımlayabiliriz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Aynur");
            isimler2.Add("Durmuş");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
