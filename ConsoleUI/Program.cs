﻿using Business.Concrete;
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

            //ProductTest();
            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal)));

        //    var result = productManager.GetAll().Data;
        //    if (result.Success)
        //    {
        //        foreach (var item in result.Data)
        //        {
        //            Console.WriteLine(item.ProductName);
                    
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        ////}
    }
}
