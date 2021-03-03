using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatası";
        public static string SuccessfulLogin = "Geçerli giriş";
        public static string UserAlreadyExists = "Kullanıcı alınmış.";
        public static string AccessTokenCreated ="Token alındı.";
    }
}
