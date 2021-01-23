using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //new leme yaptığımızda zaten default constructor çalışıyor olur
            //{ } -> parametre belirmez bu parametre almaz alttakiler parametre değildir.
            //İçinde tanımladığımız için constructor un içinde parametre tanımlamadan çalışır aksi taktirde hata verir.
            Customer customer1 = new Customer {Id=1, FirstName="Bircan", LastName="ÇİFTÇİ", City="İstanbul" };

            //bu kullanım ile üstteki kullanım aynıdır.
            Customer customer3 = new Customer();
            customer3.Id = 3;

            //böyle kullanabilmek için constructor un içinde parametreleri tanımlamak gerekir
            Customer customer2 = new Customer(2, "Serhat", "DEVECİ", "Ankara");

            Console.WriteLine(customer2.Id + " " + customer2.FirstName + " " + customer2.LastName + " " + customer2.City);

        }
    }

    class Customer
    {
        //ikisini aynı anda kullanabilmek için bir tane daha constructor tanımlanmalı
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
