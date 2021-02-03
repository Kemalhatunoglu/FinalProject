using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract klasötlerin içerisine referans tutucular konulacak yani soyut classlarımızı koyacağız.
            // Concrete klasörlerine somut classlarımızı modellerimizi koyacağız.

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
