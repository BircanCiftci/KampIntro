using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro(); komentdir

            //Demo();

            //sistemdeki bir veriyi iki farklı yere yattık
            ICustomerDal[] customerDals = new ICustomerDal[2]
            { 
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Bircan",
                LastName = "ÇİFTÇİ",
                Address = "Bolu"
            };
            manager.Add(customer);
            //üstekinin diğer yazımı
            //manager.Add(new Customer { Id = 1, FirstName = "Bircan", LastName = "ÇİFTÇİ", Address = "Bolu" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Serhat",
                LastName = "Deveci",
                Departmant = "Psikoloji"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student :IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)  //parametre olarak ekleme yapacağım bana müşteri nesnesi ver
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
