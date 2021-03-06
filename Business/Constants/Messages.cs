using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTİme = "Sistemimiz Bakımdadır";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategorideki azami ürün sayısına ulaşıldı";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten alınmış";
        public static string CategoryIdOver15 = "15ten fazla kategori var";
        public static string AuthorizationDenied = "Yetki bulunamadı";
        public static string UserRegistered= "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError= "Şifre Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı adı zaten alınmış";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
