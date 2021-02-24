using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string CategoryIdListed = "Ürünler kategoriye göre listelendi.";
        public static string UnitPriceInvalid = "Ürün uyumsuz.";
        public static string ProductCountCategoryCount = "Kategori ürün sayısını aştınız.";
        public static string ProductNameAlreadyExists = "Aynı isimde birden çok ürün eklenemez.";
        
        public static string CategoryLimitExceded = "Bir kategoriden en fazla 15 ürün olabilir.";
    }
}
