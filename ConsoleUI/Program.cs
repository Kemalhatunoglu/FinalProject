using Business.Concrete;
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

            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
