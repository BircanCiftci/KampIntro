﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QantityPerUnit = "16 GB Ram", UnitPrice = 18000, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QantityPerUnit = "8 GB Ram", UnitPrice = 18000, UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock = 15},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitsInStock = 0}
            };
            //Test(products);

            //GetProducts(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto {ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            //linq in farklı yapısı
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };  //bir liste oluşturuyor ve her bir p yi seçip listeye ekliyor 

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenBy(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-----------------------------------------");

            var result2 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            //Bir Liste dönüyor
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            //lambda
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(products => products.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik----------------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq----------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //linq yokken 
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts; //bir listeye ürünleri ekliyor
        }

        //linq varken 
        static List<Product> GetProductsLinq(List<Product> products)
        {
            //arka planda aslında yeni bir liste oluşturuyor ona ekliyor 
            //where komutu listemiz için bir döngü oluşturuyor şartlara göre şartalara uyanların herbirini yeni listeye atıyor.
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
