using System;

namespace ReferenceTypes
{
    class Program
    {
        //int,decimal,float,enum,boolean values types
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);

            //arrays,class,interface... reference types

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Bircan";
            //reference tip olduğu için referans numaraları üzerinden gider o yüzden person2 ninde firsrname i bircan dır.
            person2 = person1;
            person1.FirstName = "Derin"; //bu şekilde değiştirdiğimde person2 ninde firstname i derin olarak değişir

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Serhat";
            customer.CreditCardNumber = "1234567890"; //aynı adrese gittiği için aynı adresteki creditcardnumber a ulaşabiliriz.

            Employee employee = new Employee();
            employee.FirstName = "Ömer";

            Person person3 = customer;   //custemor bir person olduğu için atama yapabiliriz.Referansını atayabiliriz
            customer.FirstName = "Onur"; //referans üzerinden gitti için aynı adresi değiştirmiş oluruz serhat onur olarak değişir

            //person3 e customer boxing i yap demiş oluyoruz.Boxing:Kutu, şablon
            /*person önüne atanabilirlerden istediğimizin tipi yazabiliyoruz.() ikinci parantez en 
            genel parantez olur ve customer boxing e uygulanır olur*/
            Console.WriteLine(((Customer)person3).CreditCardNumber); //şeklinde person3 de credicardnumber na erişebiliriz.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    /*inheritance(miras alıyoruz) yapıyoruz.Yani personun içindekiler 
    customer ve employee içinde geçerlidir.*/
    //base class : Person - personu ebeveyn gibi düşünebiliriz
    class Customer : Person 
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    //aynı kodu farklı nesneler için çalıştırabilmeme imkan sunuyor.
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
