using Movies.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Business.Constants
{
    public static class Messages
    {
        public static string GenreDelete = "Tür silindi";
        public static string ActorAdded = "Aktör eklendi";
        public static string ActorDelete = "Aktör Silindi";
        public static string GenreAdded = "Tür eklendi";
        public static string CheckIfName = "Aynı isimden tür girilemez";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UsersAdded = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı parola";
        public static string SuccessLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Girdiğiniz kullanıcı mevcut";
        public static string AccessTokenAdded = "Tokken eklendi";
        public static string GenreUpdate = "Tür güncellendi";
    }
}
