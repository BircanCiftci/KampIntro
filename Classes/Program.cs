using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // alltaki classın bir örneğini oluşturmuş olduk yani referansını aldık
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Bircan"; //propertydeki set bloğu çalışır
            customer.LastName = "ÇİFTÇİ";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Yaren", LastName = "Derin"
            };

            Console.WriteLine(customer2.FirstName); //propertydeki get bloğu çalışır

            Console.ReadLine();
        }
    }

    

    
}
